using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.NetLib;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

namespace SharpenedMinecraft
{
    public class MinecraftPacket : NetPacket
    {
        #region Statics
        private static Dictionary<Type, Object> Types { get; set; }
        public static void RegisterType<T>(MinecraftType<T> M)
        {
            var t = typeof(T);
            if (Types.ContainsKey(t))
                throw new ArgumentException(t.Name + " is Already Registered");
            Types.Add(t, M);
        }
        public static MinecraftType<T> GetType<T>(Stream stream)
        {
            if (Types.TryGetValue(typeof(T), out object v))
            {
                var t = v.GetType();
                return (MinecraftType<T>)Activator.CreateInstance(t, (object)stream);
            }
            else
                throw new ArgumentException("Not Registered Type");
        }

        public static T ReadFromStream<T>(Stream MemoryStream)
        {
            var v = GetType<T>(MemoryStream);
            return v.Read();
        }

        public static T[] ReadArrayFromStream<T>(Stream MemoryStream, int length)
        {
            var v = GetType<T>(MemoryStream);
            return v.ReadArray(length);
        }

        public static void WriteToStream<T>(Stream MemoryStream, T value)
        {
            var v = GetType<T>(MemoryStream);
            v.Write(value);
        }

        public static void WriteArrayToStream<T>(Stream MemoryStream, T[] value)
        {
            var v = GetType<T>(MemoryStream);
            v.WriteArray(value);
        }

        static MinecraftPacket()
        {
            Types = new Dictionary<Type, object>();


            RegisterType(new MinecraftBlockState(null));
            RegisterType(new MinecraftBoolean(null));
            RegisterType(new MinecraftByte(null));
            RegisterType(new MinecraftChatMessage(null));
            RegisterType(new MinecraftDouble(null));
            RegisterType(new MinecraftFloat(null));
            RegisterType(new MinecraftInt32(null));
            RegisterType(new MinecraftLong(null));
            RegisterType(new MinecraftPosition(null));
            RegisterType(new MinecraftSByte(null));
            RegisterType(new MinecraftShort(null));
            RegisterType(new MinecraftSlot(null));
            RegisterType(new MinecraftString(null));
            RegisterType(new MinecraftUInt32(null));
            RegisterType(new MinecraftULong(null));
            RegisterType(new MinecraftUShort(null));
            RegisterType(new MinecraftVarInt(null));
            RegisterType(new MinecraftVarLong(null));
            RegisterType(new MinecraftUInt128(null));
            RegisterType(new MinecraftVector3F(null));
            RegisterType(new MinecraftNbtCompound(null));
            RegisterType(new MinecraftRotation(null));
            RegisterType(new MinecraftMetadata(null));
        }
        #endregion
        public MinecraftPacket(MinecraftClient client)
        {
            this.Client = client;
        }

        public MemoryStream MemoryStream { get; set; }
        public MinecraftClient Client { get; set; }
        public Player Player => Client.Player;
        public World World => Client.World;
        public virtual int Id { get { throw new NotImplementedException(); } }
        public virtual State State { get { throw new NotImplementedException(); } }
        public virtual bool Serverbound => false;
        public virtual bool Clientbound => false;
        public byte[] Buffer => MemoryStream.ToArray();

        public void Log(string Message)
        {
            //TODO: Add Real Logging
            Console.WriteLine(Message);
        }

        public virtual void Initialize(int length, Stream stream)
        {
            if (length < 0)
                throw new ArgumentException(nameof(length));
            else if (length == 0)
            {
                this.MemoryStream = new MemoryStream();
            }
            else
            {
                if (stream == null)
                    throw new ArgumentNullException(nameof(stream));

                this.Length = length;

                var buffer = new byte[this.Length];
                stream.Read(buffer, 0, buffer.Length);
                this.MemoryStream = new MemoryStream(buffer);
            }
        }

        public virtual void ReadPacket()
        {
            throw new NotImplementedException();
        }
        public virtual void WritePacket()
        {
            throw new NotImplementedException();
        }

        public T Read<T>()
            => ReadFromStream<T>(MemoryStream);

        public T[] ReadArray<T>(int length)
            => ReadArrayFromStream<T>(MemoryStream, length);

        public void Write<T>(T value)
            => WriteToStream(MemoryStream, value);

        public void WriteArray<T>(T[] value)
            => WriteArrayToStream(MemoryStream, value);

        public override void Dispose()
        {
            base.Dispose();
            MemoryStream.Dispose();
        }
    }
}
