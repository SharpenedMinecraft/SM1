using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.DataTypes
{
    public struct UInt128 : IEquatable<UInt128>
    {
        public UInt64 hi;
        public UInt64 lo;

        public UInt128(UInt64 hi, UInt64 lo)
        {
            this.hi = hi;
            this.lo = lo;
        }

        public bool Equals(UInt128 other)
        {
            return hi == other.hi && lo == other.lo;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is UInt128 && Equals((UInt128) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (hi.GetHashCode() * 397) ^ lo.GetHashCode();
            }
        }

        public static bool operator ==(UInt128 left, UInt128 right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(UInt128 left, UInt128 right)
        {
            return !left.Equals(right);
        }
    }
}
