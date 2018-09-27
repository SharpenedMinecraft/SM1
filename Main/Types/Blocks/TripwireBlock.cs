
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class TripwireBlock : Block
    {
        public override string BlockId => "minecraft:tripwire";
        public override BlockState[] PossibleStates { get; }
        public TripwireBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4737, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4738, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4739, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4740, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4741, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4742, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4743, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4744, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4745, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4746, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4747, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4748, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4749, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4750, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4751, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4752, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4753, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4754, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4755, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4756, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4757, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4758, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4759, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4760, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4761, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4762, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4763, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4764, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4765, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4766, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4767, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4768, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4769, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4770, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4771, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4772, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4773, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4774, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4775, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4776, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4777, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4778, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4779, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4780, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4781, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4782, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4783, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4784, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4785, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4786, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4787, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4788, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4789, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4790, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4791, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4792, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4793, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4794, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4795, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4796, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4797, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4798, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4799, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4800, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4801, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4802, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4803, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4804, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4805, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4806, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4807, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4808, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4809, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4810, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4811, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4812, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4813, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4814, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4815, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4816, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4817, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4818, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4819, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4820, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4821, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4822, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4823, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4824, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4825, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4826, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4827, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4828, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4829, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4830, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4831, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4832, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "true"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4833, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4834, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4835, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4836, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4837, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4838, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4839, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4840, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4841, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4842, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4843, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4844, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4845, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4846, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4847, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4848, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "true"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4849, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4850, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4851, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4852, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4853, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4854, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4855, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4856, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "true"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4857, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4858, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4859, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4860, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "true"},

            {"south", "false"},

            {"west", "false"},
 }),

                new BlockState(4861, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "true"},
 }),

                new BlockState(4862, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "true"},

            {"west", "false"},
 }),

                new BlockState(4863, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "true"},
 }),

                new BlockState(4864, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"disarmed", "false"},

            {"east", "false"},

            {"north", "false"},

            {"powered", "false"},

            {"south", "false"},

            {"west", "false"},
 }),

            };
            State = PossibleStates[127];

            Drops = new ItemStack[] {  };

        }
    }
}
