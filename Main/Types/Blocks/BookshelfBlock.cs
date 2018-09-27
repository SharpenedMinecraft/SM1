
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class BookshelfBlock : Block
    {
        public override string BlockId => "minecraft:bookshelf";
        public override BlockState[] PossibleStates { get; }
        public BookshelfBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1109, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new BookshelfItem() };

        }
    }
}
