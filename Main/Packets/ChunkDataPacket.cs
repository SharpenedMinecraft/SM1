using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpenedMinecraft.Entities;
using System.IO;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using SharpenedMinecraft.DataTypes;

namespace SharpenedMinecraft.Packets
{
    //http://wiki.vg/Protocol#Chunk_Data
    public class ChunkDataPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Clientbound => true;
        public override int Id => 0x21;

        // http://wiki.vg/Chunk_Format#Chunk_Section_structure
        public const byte FULL_SIZE_BITS_PER_BLOCK = 14;

        public ChunkColumn chunk;
        public Boolean GroundUpContinuous;

        public ChunkDataPacket(MinecraftClient client)
            : base(client)
        {
        }

        public override void WritePacket()
        {
            // ..
            Write((int)chunk.ChunkX);
            Write((int)chunk.ChunkZ);
            // Do we override everything?
            // NOTE: This causes problems if the given Chunk was already loaded!
            Write(GroundUpContinuous);

            var data = new MemoryStream();
            int mask = 0;
            for (int sectionY = 0; sectionY < Constants.SECTION_HEIGHT; sectionY++)
            {
                var v = chunk.chunkSections[sectionY];
                if (!v.IsEmpty)
                {
                    // Mask
                    mask |= (1 << sectionY);

                    // Actual Chunk Section Writing
                    WriteChunkSection(v, ref data);
                    Log($"Section {chunk.ChunkX}, {sectionY}, {chunk.ChunkZ} Wrote");
                }
                else
                    Log($"Section {chunk.ChunkX}, {sectionY}, {chunk.ChunkZ} Was Empty");
            }

            int[] biomes = new int[256];
            if (GroundUpContinuous) //Also write Biomes
            {
                for (int z = 0; z < Constants.SECTION_WIDTH; z++)
                {
                    for (int x = 0; x < Constants.SECTION_WIDTH; x++)
                    {
                        biomes[z * 16 | x] = chunk.Biomes[z, x].Id;
                    }
                }
            }
            WriteArrayToStream(data, biomes);

            Write((VarInt)mask);
            var dataBytes = Utils.GetBytes(data);
            Console.WriteLine("Total Data: " + data.Length + "/" + dataBytes.Length);
            data.Dispose();
            Write((VarInt)dataBytes.Length);
            WriteArray(dataBytes);

            //TODO: Support Block Entities
            Write((VarInt)0); //We dont Support Block Entities yet

        }

        private void WriteChunkSection(ChunkSection section, ref MemoryStream stream)
        {
            #region Section
            byte bitsPerBlock = FULL_SIZE_BITS_PER_BLOCK;

            MinecraftPacket.WriteToStream(stream, bitsPerBlock);
                                                        //0: disabled?
            //MinecraftPacket.WriteToStream(stream, (VarInt)0);   //up to 4: Blocks are encoded as 4 bits. The palette is used and sent.
                                                        //5 to 8: Blocks are encoded with the given number of bits.The palette is used and sent.
                                                        //9 and above: The palette is not sent. Blocks are encoded by their whole ID in the global palette, with bits per block being set as the base 2 logarithm of the number of block states, rounded up. For the current vanilla release, this is 14 bits per block.

            // A bitmask that contains bitsPerBlock set bits
            uint individualValueMask = (uint)((1 << bitsPerBlock) - 1);

            int dataLength = (Constants.SECTION_HEIGHT * Constants.SECTION_WIDTH * Constants.SECTION_DEPTH) * bitsPerBlock / 64;
            UInt64[] DataArray = new UInt64[dataLength];

            for (int y = 0; y < Constants.SECTION_HEIGHT; y++)
            {
                for (int z = 0; z < Constants.SECTION_WIDTH; z++)
                {
                    for (int x = 0; x < Constants.SECTION_WIDTH; x++)
                    {
                        var blockPos = new Vector3(x, y, z);

                        int blockNumber = ((((int)blockPos.Y * Constants.SECTION_HEIGHT) + (int)blockPos.Z) * Constants.SECTION_WIDTH) + (int)blockPos.X;
                        int startLong = (blockNumber * bitsPerBlock) / 64;
                        int startOffset = (blockNumber * bitsPerBlock) % 64;
                        int endLong = ((blockNumber + 1) * bitsPerBlock - 1) / 64;

                        Block state = section.blocks[blockPos];

                        //C# Still limits the Byte Size to uint if this is a uint,
                        //even after byteshifting into a ulong
                        ulong value = (ulong)state.GetGlobalPaletteIDFromState();
                        value &= individualValueMask;

                        DataArray[startLong] |= (value << startOffset);

                        if (startLong != endLong)
                        {
                            DataArray[endLong] = (value >> (64 - startOffset));
                        }
                    }
                }
            }

            Console.WriteLine($"Data Array was {DataArray.Length} long");
            MinecraftPacket.WriteToStream(stream, (VarInt)dataLength);
            MinecraftPacket.WriteArrayToStream(stream, DataArray);

            List<byte> BlockLightData = new List<byte>();
            for (int y = 0; y < Constants.SECTION_HEIGHT; y++)
            {
                for (int z = 0; z < Constants.SECTION_WIDTH; z++)
                {
                    for (int x = 0; x < Constants.SECTION_WIDTH; x += 2)
                    {
                        // Note: x += 2 above; we read 2 values along x each time
                        byte blocklight1 = (byte)(section.blocks[new Vector3(x, y, z)].BlockLight);
                                                             //this only works because 16 is even
                        byte blocklight2 = (byte)(section.blocks[new Vector3(x + 1, y, z)].BlockLight << 4);
                        byte value = (byte)(blocklight1 | blocklight2);
                        BlockLightData.Add(value);
                    }
                }
            }
            Console.WriteLine($"BlockLight was {BlockLightData.Count} Long");
            MinecraftPacket.WriteArrayToStream(stream, BlockLightData.ToArray());

            List<byte> SkyLightData = new List<byte>();
            if (section.HasSkylight)
            { // => current dimension is overworld / 0
                for (int y = 0; y < Constants.SECTION_HEIGHT; y++)
                {
                    for (int z = 0; z < Constants.SECTION_WIDTH; z++)
                    {
                        for (int x = 0; x < Constants.SECTION_WIDTH; x += 2)
                        {
                            // Note: x += 2 above; we read 2 values along x each time
                            byte blocklight1 = (byte)(section.blocks[new Vector3(x, y, z)].SkyLight);
                                                                     //this only works because 16 is even
                            byte blocklight2 = (byte)(section.blocks[new Vector3(x + 1, y, z)].SkyLight << 4);
                            byte value = (byte)(blocklight1 | blocklight2);
                            SkyLightData.Add(value);
                        }
                    }
                }
            }
            Console.WriteLine($"SkyLight was {SkyLightData.Count} Long");
            MinecraftPacket.WriteArrayToStream(stream, SkyLightData.ToArray());
#endregion
        }
    }
}
