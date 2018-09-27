using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Types
{
    public struct Vector3F : IEquatable<Vector3F>
    {
        public float X;
        public float Y;
        public float Z;

        public float LengthSqr { get { return (float)Math.Sqrt(X) + (float)Math.Sqrt(Y) + (float)Math.Sqrt(Z); } }
        public float Length { get { return (float)Math.Sqrt(LengthSqr); } }

        public Vector3F(float x1, float y1, float z1)
        {
            this.X = x1;
            this.Y = y1;
            this.Z = z1;
        }

        public static short ConvertToVelocity(float f)
        {
            return (short)(f / 8000);
        }

        public bool Equals(Vector3F other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return X == other.X && Y == other.Y && Z == other.Z;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Vector3F)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = X.GetHashCode();
                hashCode = (hashCode * 397) ^ Y.GetHashCode();
                hashCode = (hashCode * 397) ^ Z.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(Vector3F left, Vector3F right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Vector3F left, Vector3F right)
        {
            return !Equals(left, right);
        }

        public static implicit operator Vector3D(Vector3F vector)
        {
            return new Vector3D(vector.X, vector.Y, vector.Z);
        }

        public static Vector3F operator /(Vector3F right, float left)
        {
            return new Vector3F(right.X / left, right.Y / left, right.Z / left);
        }

        public static Vector3F operator +(Vector3F right, Vector3F left)
        {
            return new Vector3F(right.X + left.X, right.Y + left.Y, right.Z + left.Z);
        }
    }
}
