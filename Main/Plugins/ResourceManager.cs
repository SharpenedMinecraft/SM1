using SharpenedMinecraft.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;

namespace SharpenedMinecraft.Plugins
{
    public static class ResourceManager
    {
        public static ResourcePackProvider Provider { get; private set; }
        public static string ResourcesFolder => Path.GetFullPath("./Plugins/Resources/");
        private static int CurrentDamage = 1;
        public static ResourcePack DefaultRP;

        public static void Load()
        {
            DefaultRP = new ResourcePack();
            DefaultRP.Items = new Dictionary<string, ItemResource>();
            var p = Path.GetRandomFileName();
            var path = Path.GetTempPath() + Path.GetFileNameWithoutExtension(p) + "/";
            Directory.CreateDirectory(path);

            // we need the offical Minecraft Version
            using (var c = new WebClient())
                c.DownloadFile(Utils.ClientLink, path + "client.jar");

            //extract
            ZipFile.ExtractToDirectory(path + "client.jar", path);
            foreach (var v in Directory.EnumerateFiles(path, "*", SearchOption.TopDirectoryOnly))
                File.Delete(v);
            foreach (var v in Directory.EnumerateDirectories(path, "*", SearchOption.TopDirectoryOnly))
                if (Path.GetFileNameWithoutExtension(v) != "assets")
                    Directory.Delete(v, true);
            File.Delete(path + "assets/.mcassetsroot");

            foreach (var v in Directory.EnumerateFiles(path + "assets/minecraft/models/item", "*.json", SearchOption.TopDirectoryOnly))
            {
                DefaultRP.Items.Add(Path.GetFileNameWithoutExtension(v), new ItemResource()
                {
                    Path = v,
                    Model = File.ReadAllText(v),
                    ItemId = Path.GetFileNameWithoutExtension(v),
                    Type = ResourceType.Model_Item,
                });
            }

            //TODO: At the end of the programm, TMP shoud be cleaned

            Provider = new ResourcePackProvider();
        }

        public static void Build()
        {
            Provider.Build(Path.GetFullPath("./RP"));
        }

        public static String ResolveResource(String path, string Ending = "")
        {
            if (path.Contains(".."))
                throw new ArgumentException("Path injection?!");

            path = path.Replace('\\', '/');
            if (!path.StartsWith('/'))
                path = path.Insert(0, "/");
            if (Ending != string.Empty)
                if (!path.EndsWith(Ending))
                    path += Ending;
            return Path.GetFullPath(ResourcesFolder + path);
        }

        /*public static string RegisterCustomItem<T>(ItemResource v2) where T : CustomItem
        {
            v2.ItemId = "diamond_hoe_" + CurrentDamage;
            CurrentDamage++;
            return v2.ItemId;
        }*/
    }
}
