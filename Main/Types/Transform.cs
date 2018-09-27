using SharpenedMinecraft.Types.Enums;
using System;

namespace SharpenedMinecraft.Types
{
    public struct Transform : IEquatable<Transform>
    {
        public int Dimension;
        public Vector3D Position;
        public Rotation Rotation;

        public Transform(int Dimension)
        {
            this.Dimension = Dimension;
            Position = new Vector3D(0, 0, 0);
            Rotation = new Rotation(0, 0, 0);
        }

        public bool Equals(Transform other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Position.Equals(other.Position) && Rotation.Equals(other.Rotation);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Transform)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Rotation.GetHashCode();
                hashCode = (hashCode * 397) ^ Position.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(Transform left, Transform right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Transform left, Transform right)
        {
            return !Equals(left, right);
        }
    }
}