using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Types
{
    public struct Vector3D : IEquatable<Vector3D>
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public double LengthSqr { get { return Math.Sqrt(X) + Math.Sqrt(Y) + Math.Sqrt(Z); } }
        public double Length { get { return Math.Sqrt(LengthSqr); } }

        public Vector3D(double x1, double y1, double z1)
        {
            this.X = x1;
            this.Y = y1;
            this.Z = z1;
        }

        public bool Equals(Vector3D other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Vector3D) obj);
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

        public static bool operator ==(Vector3D left, Vector3D right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Vector3D left, Vector3D right)
        {
            return !Equals(left, right);
        }

        public static implicit operator Vector3(Vector3D vector)
        {
            return new Vector3((long)vector.X, (long)vector.Y, (long)vector.Z);
        }

        public static Vector3D operator /(Vector3D right, int left)
        {
            return new Vector3D(right.X / left, right.Y / left, right.Z / left);
        }

        public static Vector3D operator +(Vector3D right, Vector3D left)
        {
            return new Vector3D(right.X + left.X, right.Y + left.Y, right.Z + left.Z);
        }
    }
}
