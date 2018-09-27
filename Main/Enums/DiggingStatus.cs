using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Types.Enums
{
    //http://wiki.vg/Protocol#Player_Digging
    public enum DiggingStatus : int
    {
        StartedDigging          = 0,
        CancelledDigging        = 1,    //Sent when the player lets go of the Mine Block key (default: left click)
        FinishedDigging         = 2,    //Sent when the client thinks it is finished
        DropItemStack           = 3,    //Triggered by using the Drop Item key(default: Q) with the modifier to drop the entire selected stack(default: depends on OS). Location is always set to 0/0/0, Face is always set to -Y.
        DropItem                = 4,    //Triggered by using the Drop Item key(default: Q). Location is always set to 0/0/0, Face is always set to -Y.
        EndUseItem              = 5,    //Indicates that the currently held item should have its state updated such as eating food, pulling back bows, using buckets, etc.Location is always set to 0/0/0, Face is always set to -Y.
        SwapItemInHand          = 6     //Used to swap or assign an item to the second hand.Location is always set to 0/0/0, Face is always set to -Y.
    }
}
