using SharpenedMinecraft.Attributes;
using SharpenedMinecraft.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Entities
{
    public abstract class LivingEntity : BaseEntity
    {
        [Flags]
        public enum HandStates : byte
        {
            None = 0x00,
            IsHandActive = 0x01,
            ActiveHand = 0x02
        }

        public LivingEntity() : base()
        {
            HandState = HandStates.None;
            Health = 1.0f;
            PotionColor = 0;
            AmbientPotionEffect = false;
            NumberOfArrowsIn = 0;
        }

        [EntityMetadata(6, typeof(byte))]
        public HandStates HandState { get; set; }
        [EntityMetadata(7, typeof(float))]
        public float Health { get; set; }
        [EntityMetadata(8, typeof(VarInt))]
        public VarInt PotionColor { get; set; }
        [EntityMetadata(9, typeof(bool))]
        public bool AmbientPotionEffect { get; set; }
        [EntityMetadata(10, typeof(VarInt))]
        public VarInt NumberOfArrowsIn { get; set; }
    }
}
