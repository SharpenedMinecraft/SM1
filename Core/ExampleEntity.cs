using SharpenedMinecraft.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class ExampleEntity : ArmorStand
    {
        public override String Id => "custom:example";

        public ExampleEntity() : base()
        { }

        public override void PostTick()
        {
            LeftArmRotation.Yaw++;
            RightArmRotation.Yaw--;
            base.PostTick();
        }
    }
}
