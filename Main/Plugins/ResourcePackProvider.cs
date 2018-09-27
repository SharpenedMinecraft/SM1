using System;

namespace SharpenedMinecraft.Plugins
{
    public class ResourcePackProvider
    {
        private ResourcePack _rp;

        public ResourcePackProvider()
        {
            _rp = new ResourcePack("Generated-Server");
        }

        public void Modify(Action<ResourcePackBuilder> action)
        {
            var v = new ResourcePackBuilder(_rp);
            action(v);
            _rp = v.Build();
        }

        public void Build(String path)
        {
            _rp.ReGenerate(path);
        }
    }
}