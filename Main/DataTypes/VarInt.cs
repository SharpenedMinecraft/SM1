using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SharpenedMinecraft.DataTypes
{
    public class VarIntTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(int))
                return true;

            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is int)
                return new VarInt() { value = (int)value };

            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(VarInt))
                return ((VarInt)value).value;

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }

    [TypeConverter(typeof(VarIntTypeConverter))]
    public struct VarInt : IEquatable<VarInt>
    {
        public Int32 value { get; set; }

        public static implicit operator int(VarInt a)
        {
            return a.value;
        }

        public static implicit operator VarInt(Int32 a)
        {
            return new VarInt() { value = a };
        }

        public bool Equals(VarInt other)
        {
            return value == other.value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is VarInt && Equals((VarInt) obj);
        }

        public override int GetHashCode()
        {
            return value;
        }

        public static bool operator ==(VarInt left, VarInt right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(VarInt left, VarInt right)
        {
            return !left.Equals(right);
        }
    }
}
