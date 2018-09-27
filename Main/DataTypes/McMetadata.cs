using fNbt.Tags;
using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftMetadata : MinecraftType<Metadata>
    {
        public static Map<int, Type> Types = new Map<int, Type>()
        /*{
            { 0, typeof(byte) },
            { 1, typeof(VarInt) },
            { 2, typeof(float) },
            { 3, typeof(String) },
            { 4, typeof(MinecraftChatMessage) },
            { 5, typeof(ItemStack) },
            { 6, typeof(Boolean) },
            { 7, typeof(Rotation) },
            { 8, typeof(Vector3D) },
            //{ 9, typeof(Optional<Vector3D>) },
            { 10, typeof(VarInt) },
            //{ 11, typeof(Optional<UInt128>) },
            //{ 12, typeof(Optional<VarInt>) },
            //{ 13, typeof(Optional<NbtTag>) },
        }*/;

        static MinecraftMetadata()
        {
            Types.Add(0, typeof(byte));
            Types.Add(1, typeof(VarInt));
            Types.Add(2, typeof(float));
            Types.Add(3, typeof(String));
            Types.Add(4, typeof(MinecraftChatMessage));
            Types.Add(6, typeof(ItemStack));
            Types.Add(7, typeof(Boolean));
            Types.Add(8, typeof(Rotation));
            Types.Add(9, typeof(Vector3D));
            // Types.Add(10, typeof(VarInt)); Actually Direction
        }

        public MinecraftMetadata(Stream stream) : base(stream)
        {
        }

        public override Metadata Read()
        {
            var v = new Metadata();
            var v2 = new Dictionary<int, Metadata.MetadataInfo>();
            var vi = new MinecraftVarInt(Stream);
            var b = new MinecraftByte(Stream);
            var func = typeof(MinecraftPacket).GetMethod("ReadFromStream");
            while (true)
            {
                byte val = b.Read();
                if (val == 0xff)
                    break;
                var t = Types.Forward[vi.Read()];
                v2.Add(val, new Metadata.MetadataInfo()
                {
                    Type = t,
                    value = func.MakeGenericMethod(t).Invoke(null, new object[] { Stream })
                });
            }
            v.Infos = v2;
            return v;
        }

        public override void Write(Metadata value)
        {
            var vi = new MinecraftVarInt(Stream);
            var b = new MinecraftByte(Stream);
            var func = typeof(MinecraftPacket).GetMethod("WriteToStream", BindingFlags.Static | BindingFlags.Public);
            var f2 = typeof(MinecraftMetadata).GetMethod("C", BindingFlags.Static | BindingFlags.Public);
            foreach (var v in value.Infos)
            {
                b.Write((byte)v.Key);
                vi.Write(Types.Reverse[v.Value.Type]);
                var v2 = f2.MakeGenericMethod(v.Value.Type).Invoke(null, new object[] { v.Value.value });
                func.MakeGenericMethod(v.Value.Type).Invoke(null, new object[] { Stream, v2 });
            }
            b.Write(0xff);
        }

        public static T C<T>(object v)
        {
            return (T)v;
        }
    }
}
