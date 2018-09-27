using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Attributes
{
    [System.AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    sealed class EntityMetadataAttribute : Attribute
    {
        public EntityMetadataAttribute(int index, Type type)
        {
            Index = index;
            Type = type;
        }

        public int Index { get; }
        public Type Type { get; }
    }
}
