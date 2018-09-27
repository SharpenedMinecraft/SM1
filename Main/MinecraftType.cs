using System;
using System.IO;
using System.Threading.Tasks;

namespace SharpenedMinecraft
{
    public abstract class MinecraftType<T>
    {
        public MinecraftType(Stream stream)
        {
            this.Stream = stream;
        }

        public Stream Stream { get; set; }

        public abstract T Read();
        public abstract void Write(T value);

        public virtual T[] ReadArray(int length)
        {
            var result = new T[length];
            if (length == 0) return result;
            for (int i = 0; i < length; i++)
                result[i] = Read();
            return result;
        }

        public virtual void WriteArray(T[] value)
        {
            for (int i = 0; i < value.Length; i++)
                Write(value[i]);
        }
    }
}