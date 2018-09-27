using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Types
{
    public struct Vector2F : IEquatable<Vector2F>
    {

        public Vector2F(float x1, float y1)
        {
            this.X = x1;
            this.Y = y1;
        }

        public float X { get; set; }
        public float Y { get; set; }

        public bool Equals(Vector2F other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Vector2F)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = X.GetHashCode();
                hashCode = (hashCode * 397) ^ Y.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(Vector2F left, Vector2F right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Vector2F left, Vector2F right)
        {
            return !Equals(left, right);
        }
    }
}
