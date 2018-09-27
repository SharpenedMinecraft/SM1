using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types
{
    public class Rotation : IEquatable<Rotation>
    {
        private float x;
        private float y;
        private float z;

        public float Yaw { 
            get => x;
            set => x = value % 360;
        }
        public float Pitch {
            get => y;
            set => y = value % 360;
        }
        public float Roll { 
            get => z;
            set => z = value % 360;
        }

        public static byte ToLesser(float f)
        {
            return (byte)(((f / 360) * 256) % 256);
        }

        public float LengthSqr { get { return (float)Math.Sqrt(Yaw) + (float)Math.Sqrt(Pitch) + (float)Math.Sqrt(Roll); } }
        public float Length { get { return (float)Math.Sqrt(LengthSqr); } }

        public Rotation(float x1, float y1, float z1)
        {
            x = x1;
            y = y1;
            z = z1;
        }

        public bool Equals(Rotation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Rotation) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = x.GetHashCode();
                hashCode = (hashCode * 397) ^ y.GetHashCode();
                hashCode = (hashCode * 397) ^ z.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(Rotation left, Rotation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Rotation left, Rotation right)
        {
            return !Equals(left, right);
        }
    }
}
