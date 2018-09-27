using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SharpenedMinecraft.DataTypes
{
    public class VarLongTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(long))
                return true;

            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is long)
                return new VarLong() { value = (long)value };

            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(VarLong))
                return ((VarLong)value).value;

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }

    [TypeConverter(typeof(VarLongTypeConverter))]
    public struct VarLong : IEquatable<VarLong>
    {
        public Int64 value { get; set; }

        public static implicit operator Int64(VarLong a)
        {
            return a.value;
        }

        public static implicit operator VarLong(Int64 a)
        {
            return new VarLong() {value = a };
        }

        public bool Equals(VarLong other)
        {
            return value == other.value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is VarLong && Equals((VarLong) obj);
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        public static bool operator ==(VarLong left, VarLong right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(VarLong left, VarLong right)
        {
            return !left.Equals(right);
        }
    }
}
