using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Plugins
{
    public class ResourceBuilder
    {
        private Resource _r;

        public ResourceBuilder(Resource r)
        {
            _r = r;
        }

        public Resource Build()
            => _r;
    }
}
