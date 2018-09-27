using System;
using System.Collections.Generic;
using System.IO;

namespace SharpenedMinecraft.Plugins
{
    public class ResourcePack
    {
        public string Name { get; set; }
        public Dictionary<string, ItemResource> Items { get; set; }
        public List<Resource> Resources { get; set; }

        public ResourcePack(string name)
        {
            Name = name;
            Items = ResourceManager.DefaultRP.Items;
            Resources = new List<Resource>();
        }

        internal ResourcePack()
        {

        }

        public void ReGenerate(string path)
        {
            string RPPath = Path.GetFullPath("./RP/");
            while (Directory.Exists(RPPath))
                try
                { Directory.Delete(RPPath, true); }
                catch { }
            Directory.CreateDirectory(RPPath + "/assets/");
            Directory.CreateDirectory(RPPath + "/assets/minecraft/");
            string basePath = RPPath + "/assets/minecraft/";
            Directory.CreateDirectory(basePath + "models/");

            foreach (var v in Items)
            {
                try
                {
                    if (!Directory.Exists(basePath + "models/items/"))
                        Directory.CreateDirectory(basePath + "models/items/");
                }
                catch { }
                File.Copy(v.Value.Path, basePath + "models/items/" + v.Key + ".json");
            }

            foreach (var v in Resources)
            {
                string v2;
                switch (v.Type)
                {
                    case ResourceType.Blockstate:
                        v2 = "blockstates/";
                        break;
                    case ResourceType.Model:
                        v2 = "models/";
                        break;
                    case ResourceType.Model_Item:
                        v2 = "models/items/";
                        break;
                    case ResourceType.Model_Block:
                        v2 = "models/blocks/";
                        break;
                    case ResourceType.Texture:
                        v2 = "textures/";
                        break;
                    default:
                        throw new ArgumentException();
                }
                v2 += v.Folder;
                try
                {
                    if (!Directory.Exists(basePath + v2))
                        Directory.CreateDirectory(basePath + v2);
                }
                catch { }
                string p = basePath + v2 + Path.GetFileName(v.Path);
                if (!File.Exists(p))
                    File.Copy(v.Path, p);
            }
        }
    }
}