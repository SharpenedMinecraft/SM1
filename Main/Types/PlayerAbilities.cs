using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Types
{
    public class PlayerAbilities
    {
        [Flags]
        public enum Abilities : byte
        {
            NONE = 0x00,
            Invulnerable = 0x01,
            Flying = 0x02,
            AllowFlying = 0x04,
            CreativeMode = 0x08
        }

        public Abilities Flags { get; set; }
        public float FlyingSpeed { get; set; }
        public float FOVMod { get; set; }

        public PlayerAbilities()
        {
            Flags = Abilities.NONE;
            FlyingSpeed = 1;
            FOVMod = 1;
        }
    }
}
