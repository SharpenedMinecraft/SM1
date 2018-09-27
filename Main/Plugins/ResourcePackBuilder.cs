using System;
using System.IO;
using SharpenedMinecraft.Types;

namespace SharpenedMinecraft.Plugins
{
    public class ResourcePackBuilder
    {
        private ResourcePack _rp;

        public ResourcePackBuilder(ResourcePack rp)
        {
            this._rp = rp;
        }

        public ResourcePack Build()
        {
            return _rp;
        }

        public void ModifyItem<T>(Action<ResourceBuilder> p) where T : ItemStack
        {
            throw new NotImplementedException();
        }
    }
}