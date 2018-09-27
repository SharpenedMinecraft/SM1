using SharpenedMinecraft.DataTypes;
using System;
using System.IO;
using Xunit;

namespace SharpenedMinecraft.Tests
{
    public class DataTypes
    {
        [Fact]
        public void VarInt()
        {
            //Data Taken from Wiki: http://wiki.vg/Protocol (See "Sample VarInts")

            //0
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarInt(m);
                i.Write(0);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 1, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)0);
            }
            
            //1
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarInt(m);
                i.Write(1);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 1, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)1);
            }

            //2
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarInt(m);
                i.Write(2);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 1, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)2);
            }

            //127
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarInt(m);
                i.Write(127);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 1, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)127);
            }

            //128
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarInt(m);
                i.Write(128);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 2, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)128 && bytes[1] == (byte)1);
            }

            //255
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarInt(m);
                i.Write(255);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 2, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)255 && bytes[1] == (byte)1);
            }

            //2147483647
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarInt(m);
                i.Write(2147483647);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 5, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)255
                    && bytes[1] == (byte)255
                    && bytes[2] == (byte)255
                    && bytes[3] == (byte)255
                    && bytes[4] == (byte)7);
            }

            //-1
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarInt(m);
                i.Write(-1);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 5, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)255
                    && bytes[1] == (byte)255
                    && bytes[2] == (byte)255
                    && bytes[3] == (byte)255
                    && bytes[4] == (byte)15);
            }

            //-2147483648
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarInt(m);
                i.Write(-2147483648);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 5, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)128
                    && bytes[1] == (byte)128
                    && bytes[2] == (byte)128
                    && bytes[3] == (byte)128
                    && bytes[4] == (byte)8);
            }
        }
        [Fact]
        public void VarLong()
        {
            //Data from: http://wiki.vg/Protocol

            //0
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarLong(m);
                i.Write(0);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 1, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)0);
            }

            //1
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarLong(m);
                i.Write(1);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 1, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)1);
            }

            //2
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarLong(m);
                i.Write(2);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 1, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)2);
            }

            //127
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarLong(m);
                i.Write(127);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 1, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)127);
            }

            //128
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarLong(m);
                i.Write(128);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 2, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)128 && bytes[1] == (byte)1);
            }

            //255
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarLong(m);
                i.Write(255);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 2, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)255 && bytes[1] == (byte)1);
            }

            //2147483647
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarLong(m);
                i.Write(2147483647);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 5, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)255
                    && bytes[1] == (byte)255
                    && bytes[2] == (byte)255
                    && bytes[3] == (byte)255
                    && bytes[4] == (byte)7);
            }

            //9223372036854775807
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarLong(m);
                i.Write(9223372036854775807);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 9, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)255
                    && bytes[1] == (byte)255
                    && bytes[2] == (byte)255
                    && bytes[3] == (byte)255
                    && bytes[4] == (byte)255
                    && bytes[5] == (byte)255
                    && bytes[6] == (byte)255
                    && bytes[7] == (byte)255
                    && bytes[8] == (byte)127);
            }

            //-1
            using (var m = new MemoryStream(12000))
            {
                var i = new MinecraftVarLong(m);
                i.Write(-1);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 10, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)255
                    && bytes[1] == (byte)255
                    && bytes[2] == (byte)255
                    && bytes[3] == (byte)255
                    && bytes[4] == (byte)255
                    && bytes[5] == (byte)255
                    && bytes[6] == (byte)255
                    && bytes[7] == (byte)255
                    && bytes[8] == (byte)255
                    && bytes[9] == (byte)1);
            }

            //-2147483648
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarLong(m);
                i.Write(-2147483648);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 10, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)128
                    && bytes[1] == (byte)128
                    && bytes[2] == (byte)128
                    && bytes[3] == (byte)128
                    && bytes[4] == (byte)248
                    && bytes[5] == (byte)255
                    && bytes[6] == (byte)255
                    && bytes[7] == (byte)255
                    && bytes[8] == (byte)255
                    && bytes[9] == (byte)1);
            }

            //-9223372036854775808
            using (var m = new MemoryStream(6000))
            {
                var i = new MinecraftVarLong(m);
                i.Write(-9223372036854775808);
                var bytes = Utils.GetBytes(i.Stream);
                Assert.True(bytes.Length == 10, "Array has the Wrong size");
                Assert.True(bytes[0] == (byte)128
                    && bytes[1] == (byte)128
                    && bytes[2] == (byte)128
                    && bytes[3] == (byte)128
                    && bytes[4] == (byte)128
                    && bytes[5] == (byte)128
                    && bytes[6] == (byte)128
                    && bytes[7] == (byte)128
                    && bytes[8] == (byte)128
                    && bytes[9] == (byte)1);
            }
        }
    }
}
