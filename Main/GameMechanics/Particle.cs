using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Packets;
using SharpenedMinecraft.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.GameMechanics
{
    public static class Particle
    {
        public static Dictionary<string, int> ParticleIds = new Dictionary<string, int>()
        {
            { "explode", 0 },
            { "largeexplode", 1 },
            { "hugeexplode", 2 },
            { "fireworksSpark", 3 },
            { "bubble", 4 },
            { "splash", 5 },
            { "wake", 6 },
            { "suspended", 7 },
            { "depthsuspend", 8 },
            { "crit", 9 },
            { "magicCrit", 10 },
            { "smoke", 11 },
            { "largesmoke", 12 },
            { "spell", 13 },
            { "instantspell", 14 },
            { "mobSpell", 15 },
            { "mobSpellAmbient", 16 },
            { "witchMagic", 17 },
            { "dripWater", 18 },
            { "dripLava", 19 },
            { "angryVillager", 20 },
            { "happyVillager", 21 },
            { "townaura", 22 },
            { "note", 23 },
            { "portal", 24 },
            { "enchantmenttable", 25 },
            { "flame", 26 },
            { "lava", 27 },
            { "footstep", 28 },
            { "cloud", 29 },
            { "reddust", 30 },
            { "snowballpoof", 31 },
            { "snowshovel", 32 },
            { "slime", 33 },
            { "heart", 34 },
            { "barrier", 35 },
            //TODO: Implement these Particles
            { "iconcrack_(id)_(data)", 36 },
            { "blockcrack_(id+(data<<12))", 37 },
            { "blockdust_(id)", 38 },
            { "droplet", 39 },
            { "take", 40 },
            { "mobappearance", 41 },
            { "dragonbreath", 42 },
            { "endrod", 43 },
            { "damageindicator", 44 },
            { "sweepattack", 45 },
            { "fallingdust", 46 },
            { "totem", 47 },
            { "spit", 48 },
        };

        public static void SpawnParticle(string name, Vector3F Position, Vector3F Offset, Int32 ParticleCount, bool LongRange = false, float ParticleData = 0f, VarInt[] Data = null)
        {
            if (Data == null)
                Data = new VarInt[0];
            string defaultNamespace = "minecraft:";
            if (name.StartsWith(defaultNamespace))
                name = name.Remove(0, defaultNamespace.Length);

            SpawnParticle(ParticleIds[name], Position, Offset, ParticleCount, LongRange, ParticleData, Data);
        }
        public static void SpawnParticle(int id, Vector3F Position, Vector3F Offset, Int32 ParticleCount, bool LongRange = false, float ParticleData = 0f, VarInt[] Data = null)
        {
            if (Data == null)
                Data = new VarInt[0];

            World.Players[0].Client.SendToAll(new SpawnParticlePacket(null)
            {
                ID = id,
                LongRange = LongRange,
                Position = Position,
                Offset = Offset,
                ParticleCount = ParticleCount,
                ParticleData = ParticleData,
                Data = Data
            });
        }
    }
}
