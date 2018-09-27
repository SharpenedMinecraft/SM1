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

namespace PrismarineDataGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to Generate CS files, P + Enter generates MC-data files");
            string s = Console.ReadLine();
            if (s == "P")
                UpdatePrismarine();
            else if (s == "")
                GenerateFiles();
            else
                throw new ArgumentException();
        }

        private static void GenerateFiles()
        {
            throw new NotImplementedException();
        }

        private static void UpdatePrismarine()
        {
            GetServerReports(out Dictionary<string, MinecraftBlock> Blocks, out Dictionary<string, Item> Items);
            GetLatestPrismarine(out List<PrismarineBlock> PrismarineBlocks, out List<PrismarineItem> PrismarineItems);
            List<PrismarineBlock> newBlocks = new List<PrismarineBlock>();
            List<PrismarineItem> newItems = new List<PrismarineItem>();
            foreach (var block in Blocks)
            {
                var pb = PrismarineBlocks.First(x => x.name == block.Key);
                newBlocks.Add(new PrismarineBlock()
                {
                    BlockId = block.Key,
                    boundingBox = pb.boundingBox,
                    Diggable = pb.Diggable,
                    displayName = pb.displayName,
                    Drops = null, //TODO: Add Linking
                    EmitLight = pb.EmitLight,
                    FilterLight = pb.FilterLight,
                    Hardness = pb.Hardness,
                    Properties = MakePBProperties(block.Value.Properties),
                    States = block.Value.States,
                    Transparent = pb.Transparent
                });
            }


            foreach (var item in Items)
            {


            }
        }

        private static Dictionary<String, PrismarineType> MakePBProperties(Dictionary<String, String[]> properties)
        {
            var res = new Dictionary<string, PrismarineType>();
            foreach (var v in properties)
            {
                res.Add(v.Key, GetPrismarineType(v.Value));
            }
            return res;
        }

        private static PrismarineType GetPrismarineType(String[] value)
        {
            if (value.All(x => Int32.TryParse(x, out int no)))
                return PrismarineType.int32;
            if (value.All(x => Boolean.TryParse(x, out bool no)))
                return PrismarineType.Bool;

            return PrismarineType.Enum;
        }

        private static void GetLatestPrismarine(out List<PrismarineBlock> prismarineBlocks, out List<PrismarineItem> prismarineItems)
        {
            throw new NotImplementedException();
        }

        private static void GetServerReports(out Dictionary<String, MinecraftBlock> blocks, out Dictionary<String, Item> items)
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

            blocks = Converters.BlocksFromJson(File.ReadAllText($"{ResourcesPath}/blocks.json"));
            items = Converters.ItemsFromJson(File.ReadAllText($"{ResourcesPath}/items.json"));
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

        public class PrismarineItem
        {
            [J("id")] public int ProtocolId { get; set; }
            [J("displayName")] public string DisplayName { get; set; }
            [J("stackSize")] public int StackSize { get; set; }
            [J("name")] public string Name { get; set; }
        }

        public class PrismarineBlock
        {
            [J("id")] public string BlockId { get; set; }
            [J("displayName")] public string displayName { get; set; }
            // there is no name, only used for back-porting
            [J("name", DefaultValueHandling = DefaultValueHandling.Ignore)] public string name { get; set; }
            [J("hardness")] public int Hardness { get; set; }
            // Such a thing as stack size is simply not a thing. replaced by Item
            [J("diggable")] public bool Diggable { get; set; }
            [J("boundingBox")] public string boundingBox { get; set; }
            [J("drops")] public string Drops { get; set; }
            [J("transparent")] public bool Transparent { get; set; }
            [J("emitLight")] public int EmitLight { get; set; }
            [J("filterLight")] public int FilterLight { get; set; }
            [J("properties")] public Dictionary<string, PrismarineType> Properties { get; set; }
            [J("states")] public BlockSubState[] States { get; set; }
        }

        public enum PrismarineType
        {
            Enum,
            int32,
            Bool,
        }

        public partial class BlockSubState
        {
            [J("properties")] public Dictionary<string, string> Properties { get; set; }
            [J("id")] public long Id { get; set; }
            [J("default", NullValueHandling = N.Include)] public bool Default { get; set; }
        }

        public partial class MinecraftBlock
        {
            [J("states")] public BlockSubState[] States { get; set; }
            [J("properties")] public Dictionary<string, string[]> Properties { get; set; }
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
}
