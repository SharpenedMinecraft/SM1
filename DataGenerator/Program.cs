using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using J = Newtonsoft.Json.JsonPropertyAttribute;
using R = Newtonsoft.Json.Required;
using N = Newtonsoft.Json.NullValueHandling;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Linq;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading...");
            var ResourcesPath = Path.GetFullPath("./Resources");
            while (Directory.Exists(ResourcesPath))
                try
                {
                    Directory.Delete(ResourcesPath, true);
                }
                catch { }
            Directory.CreateDirectory(ResourcesPath);
            Console.WriteLine("Coudn't find Blocks.json, Generating");
            Console.WriteLine("Downloading Original Server.....");
            Console.WriteLine("=> This is needed to Get the Blocks");
            SaveServerToFile(ResourcesPath + "/server.jar");
            Console.WriteLine("Downloaded Server, Running Generator");
            //Server shoud generate reports
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/C cd {ResourcesPath}/ && java -cp server.jar net.minecraft.data.Main --reports";
            process.StartInfo = startInfo;
            Console.WriteLine("----------------[START OF ORIGINAL SERVER CONSOLE]----------------");
            process.Start();
            Task.Delay(25 * 1000).Wait(); // ... Not nice, but .WaitForExit() isnt working anymore for some reason
            Console.WriteLine("-----------------[END OF ORIGINAL SERVER CONSOLE]-----------------");
            Console.WriteLine("Copying Files");
            foreach (string file in Directory.EnumerateFiles(ResourcesPath + "/generated/reports/"))
            {
                File.Move(file, ResourcesPath + "/" + Path.GetFileName(file));
            }
            Console.WriteLine("Deleting Cache");
            while (Directory.Exists(ResourcesPath + "/generated/"))
                try
                {
                    Directory.Delete(ResourcesPath + "/generated/", true);
                }
                catch { }
            while (Directory.Exists(ResourcesPath + "/logs/"))
                try
                {
                    Directory.Delete(ResourcesPath + "/logs/", true);
                }
                catch { }
            Console.WriteLine("Done Loading! We got the Files");
            Console.WriteLine("Hi! Please first choose a mode: [item, block]");
            string mode = Console.ReadLine();
            var itemsPath = ResourcesPath + "/items.json";
            var Items = Converters.ItemsFromJson(File.ReadAllText(itemsPath));
            var blocksPath = ResourcesPath + "/blocks.json";
            Dictionary<string, MinecraftBlock> Blocks = Converters.BlocksFromJson(File.ReadAllText(blocksPath));
            switch (mode)
            {
                case "both":
                    GenerateBlocks(Blocks, Items, ResourcesPath);
                    GenerateItems(Items, Blocks, ResourcesPath);
                    break;

                case "item":
                    GenerateItems(Items, Blocks, ResourcesPath);
                    break;
                case "block":
                    GenerateBlocks(Blocks, Items, ResourcesPath);
                    break;
            }
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }

        private const string ServerURL = "https://launcher.mojang.com/mc/game/18w22c/server/d66173b86e26e6835e36c63eb2828652186a4698/server.jar";

        public static void SaveServerToFile(string path)
        {
            var p = Path.GetFullPath(path);
            using (var c = new WebClient())
            {
                c.DownloadFile(ServerURL, p);
            }
        }

        public static void GenerateBlocks(Dictionary<string, MinecraftBlock> Blocks, Dictionary<string, Item> Items, string ResourcesPath)
        {
            Console.WriteLine("Generating Blocks");
            var OutputDir = Path.GetFullPath("./Output/blocks");
            while (Directory.Exists(OutputDir))
                try
                {
                    Directory.Delete(OutputDir, true);
                }
                catch { }
            while (!Directory.Exists(OutputDir))
                try
                {
                    Directory.CreateDirectory(OutputDir);
                }
                catch { }
            foreach (var block in Blocks)
            {

                // "" will be ignored
                string name = block.Key.Replace("minecraft:", "");
                name = name.First().ToString().ToUpper() + name.Substring(1);
                var statecode = @"
            PossibleStates = new BlockState[]
            {";
                int def = 0;
                for (int i = 0; i < block.Value.States.Length; i++)
                {
                    var state = block.Value.States[i];
                    string s = "";
                    if (state.Properties != null)
                        foreach (var v in state.Properties)
                        {
                            s += $@"
            {{""{v.Key}"", ""{v.Value}""}},
";
                        }

                    if (state.Default)
                        def = i;

                    statecode += $@"
                new BlockState({state.Id}, new Dictionary<string, string>
                {{ {s} }}),
";
                }
                statecode += $@"
            }};
            State = PossibleStates[{def}];
";
                var s2 = "";
                foreach (var i in Items.Where(x => x.Key == block.Key))
                {
                    string name2 = block.Key.Replace("minecraft:", "");
                    name2 = name2.First().ToString().ToUpper() + name2.Substring(1);
                    s2 += $"new {name2}Item(), ";
                }
                if (s2 != "")
                    s2 = s2.Remove(s2.Length - 2, 2);
                statecode += $@"
            Drops = new ItemStack[] {{ {s2} }};
";

                var code = $@"
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{{
    public class {name}Block : Block
    {{
        public override string BlockId => ""{block.Key}"";
        public override BlockState[] PossibleStates {{ get; }}
        public {name}Block() : base()
        {{
{statecode}
        }}
    }}
}}
";
                File.WriteAllText(OutputDir + $"/{name}Block.cs", code);
            }
            Console.WriteLine("Generated Blocks");
        }

        public static void GenerateItems(Dictionary<string, Item> Items, Dictionary<string, MinecraftBlock> Blocks, string ResourcesPath)
        {
            Console.WriteLine("Generating Items");
            var OutputDir = Path.GetFullPath("./Output/items");
            if (Directory.Exists(OutputDir))
                Directory.Delete(OutputDir, true);
            Directory.CreateDirectory(OutputDir);
            foreach (var item in Items)
            {
                string name = item.Key.Replace("minecraft:", "");
                name = name.First().ToString().ToUpper() + name.Substring(1);
                string s = "";
                if (Blocks.Any(x => x.Key == item.Key))
                s = $@"
        public override void OnRightClick(World world, Vector3 Pos, Player player)
        {{
            world.SetBlock(Pos, new {name}Block(), player);
        }}
";
                var code2 = $@"
using SharpenedMinecraft.Types.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Items
{{
    public class {name}Item : ItemStack
    {{
        public override string Id => ""{item.Key}"";
        public override Int32 ProtocolId => {item.Value.Id};
      
        {s}
    }}
}}
";
                File.WriteAllText(OutputDir + $"/{name}Item.cs", code2);
            }
            Console.WriteLine("Generated Items");
        }
    }

    

    public partial class MinecraftBlock
    {
        [J("states")] public BlockSubState[] States { get; set; }
        [J("properties")] public Dictionary<string, string[]> Properties { get; set; }
    }

    public partial class BlockSubState
    {
        [J("properties")] public Dictionary<string, string> Properties { get; set; }
        [J("id")] public long Id { get; set; }
        [J("default", NullValueHandling = N.Include)] public bool Default { get; set; }
    }

    public partial class Converters
    {
        public static Dictionary<string, MinecraftBlock> BlocksFromJson(string json) => JsonConvert.DeserializeObject<Dictionary<string, MinecraftBlock>>(json, Converter.Settings);
        public static Dictionary<string, Item> ItemsFromJson(string json) => JsonConvert.DeserializeObject<Dictionary<string, Item>>(json, Converter.Settings);
    }

    public class Item
    {
        [J("protocol_id")] public int Id { get; set; }
    }

    public static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
