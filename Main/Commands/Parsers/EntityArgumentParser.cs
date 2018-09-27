using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Commands.Parsers
{
    public class EntityArgumentParser : ArgumentParser
    {
        public override String ID => "minecraft:entity";
        public bool onlyOne, onlyPlayers;
        public EntityArgumentParser(bool onlyOne = false, bool onlyPlayers = false) : base()
        {
            this.onlyOne = onlyOne;
            this.onlyPlayers = onlyPlayers;
        }

        public override Object Parse(CommandContext ctx)
        {
            String s = ctx.Segments[0];
            //@p[name=YoMama]
            if (s.StartsWith('@')) //p[name=YoMama]
                s = s.Remove(0, 1);
            else
                return null;

            char selector = s[0]; //p
            string options = s.Remove(0, 1); //[name=YoMama]
            List<Predicate<BaseEntity>> Options = new List<Predicate<BaseEntity>>();
            if (options != "")
            {
                if (!(options.StartsWith('[') && options.EndsWith(']')))
                    return null;
                //Resolve options into Func
                options = options.Remove(0, 1);
                options = options.Remove(options.Length - 1, 1); //name=YoMama
                foreach (var option in options.Split(','))
                {
                    var v = option.Split('=');
                    var obj = v[0]; //name
                    var value = v[1]; //YoMama
                    bool not = value.StartsWith('!');
                    if (not) value = value.Remove(0, 1);
                    switch (obj)
                    {
                        case "name":
                            Options.Add(x => x.CustomName.Text == value ^ not); //??
                            break;
                            //TODO: [CMDS] Implement more Filters

                        default:
                            return null;
                    }
                }
            }
            else
                Options.Add(x => true);

            List<BaseEntity> res = new List<BaseEntity>();
            foreach (var v in World.Entities)
            {
                if (Options.TrueForAll(x => x(v)))
                    res.Add(v);

                if (onlyPlayers)
                    res.RemoveAll(x => ((Player)x) == null);
            }

            //Apply Selector
            switch (selector)
            {
                case 'p':
                    return new List<BaseEntity>() { Closest(ctx.Position, res) };
                case 'r':
                    var r = new Random();
                    return new List<BaseEntity>() { res[r.Next(res.Count - 1)] };
                case 'a':
                    if (!onlyPlayers)
                        res.RemoveAll(x => ((Player)x) == null);
                    return res;
                case 'e':
                    return res;

                default:
                    return null;
            }
        }

        private BaseEntity Closest(Vector3D position, List<BaseEntity> res)
        {
            BaseEntity closest = null;
            double distance = double.MaxValue;
            foreach (var v in res)
            {
                var dis = v.Transform.Position.Length - position.Length;
                if (dis < 0)
                    dis *= -1;
                if (dis < distance)
                {
                    distance = dis;
                    closest = v;
                }
            }
            return closest;
        }
    }
}
