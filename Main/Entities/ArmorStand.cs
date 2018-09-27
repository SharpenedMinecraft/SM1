using SharpenedMinecraft.Attributes;
using SharpenedMinecraft.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Entities
{
    public class ArmorStand : LivingEntity
    {
        public override int EntityId { get; set; }
        public override SpawnMethodes SpawnMethode
         => SpawnMethodes.Object;
        public override byte SpawnId
            => 78;
        public override string Id => "minecraft:armor_stand";
        [EntityMetadata(11, typeof(Byte))]
        public ArmorStandData Data { get; set; }
        [EntityMetadata(12, typeof(Rotation))]
        public Rotation HeadRotation { get; set; }
        [EntityMetadata(13, typeof(Rotation))]
        public Rotation BodyRotation { get; set; }
        [EntityMetadata(14, typeof(Rotation))]
        public Rotation LeftArmRotation { get; set; }
        [EntityMetadata(15, typeof(Rotation))]
        public Rotation RightArmRotation { get; set; }
        [EntityMetadata(16, typeof(Rotation))]
        public Rotation LeftLegRotation { get; set; }
        [EntityMetadata(17, typeof(Rotation))]
        public Rotation RightLegRotation { get; set; }

        public ArmorStand() : base()
        {
            Data = ArmorStandData.None;
            Data |= ArmorStandData.HasArms;
            Data |= ArmorStandData.NoBasePlate;

            HeadRotation = new Rotation(0.0f, 0.0f, 0.0f);
            BodyRotation = new Rotation(0.0f, 0.0f, 0.0f);
            LeftArmRotation = new Rotation(-10.0f, 0.0f, -10.0f);
            RightArmRotation = new Rotation(-15.0f, 0.0f, 10.0f);
            LeftLegRotation = new Rotation(-1.0f, 0.0f, -1.0f);
            RightLegRotation = new Rotation(1.0f, 0.0f, 1.0f);
        }

        [Flags]
        public enum ArmorStandData : byte
        {
            None = 0x00,
            IsSmall = 0x01,
            HasArms = 0x04,
            NoBasePlate = 0x08,
            SetMarker = 0x10
        }
    }
}
