using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Packets
{
    public class SetSlotPacket : MinecraftPacket
    {
        public override int Id => 0x16;
        public override State State => State.Play;
        public override bool Clientbound => true;

        public SetSlotPacket(MinecraftClient client) : base(client)
        {
        }

        public byte WindowId = 0;
        public short SlotId;
        public ItemStack SlotData;

        public override void WritePacket()
        {
            Write(WindowId);
            Write(SlotId);
            Player.OpenWindows[WindowId].slots[SlotId] = SlotData;
            Write(SlotData);
        }
    }
}
