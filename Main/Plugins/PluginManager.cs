using SharpenedMinecraft.SDK;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SharpenedMinecraft.Plugins
{
    public class PluginManager
    {
        private static List<McPlugin> _plugins;

        public static void LoadPlugins(String path)
        {
            _plugins = new List<McPlugin>();

            foreach (var file in Directory.EnumerateFiles(path, "*.dll", SearchOption.AllDirectories))
            {
                var a = Assembly.LoadFile(file);
                var Types = a.GetTypes().Where(x => typeof(McPlugin).IsAssignableFrom(x));
                foreach (var t in Types)
                {
                    var v = (McPlugin)Activator.CreateInstance(t);
                    Console.WriteLine("Loaded Plugin " + v.Name);
                    _plugins.Add(v);
                }
            }
        }
    }
}
