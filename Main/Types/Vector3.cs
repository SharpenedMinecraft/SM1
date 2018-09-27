using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Types
{
    public struct Vector3 : IEquatable<Vector3>
    {
        public long X;
        public long Y;
        public long Z;

        public long LengthSqr { get { return (long)Math.Sqrt(X) + (long)Math.Sqrt(Y) + (long)Math.Sqrt(Z); } }
        public long Length { get { return (long)Math.Sqrt(LengthSqr); } }

        public Vector3(long x1, long y1, long z1)
        {
            this.X = x1;
            this.Y = y1;
            this.Z = z1;
        }

        public bool Equals(Vector3 other)
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
            return Equals((Vector3) obj);
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

        public static bool operator ==(Vector3 left, Vector3 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Vector3 left, Vector3 right)
        {
            return !Equals(left, right);
        }

        public static implicit operator Vector3D(Vector3 vector)
        {
            return new Vector3D(vector.X, vector.Y, vector.Z);
        }

        public static Vector3 operator /(Vector3 right, long left)
        {
            return new Vector3(right.X / left, right.Y / left, right.Z / left);
        }

        public static Vector3 operator +(Vector3 right, Vector3 left)
        {
            return new Vector3(right.X + left.X, right.Y + left.Y, right.Z + left.Z);
        }
    }
}
