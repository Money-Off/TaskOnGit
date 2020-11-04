using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace lib
{
    internal abstract class PluginBase : IPlugin
    {
        public string PluginName { get; }

        public string Version { get; }

        protected PluginBase(string pluginName, string version, string description)
        {
            Version = version;
            Description = description;
            PluginName = pluginName;
        }

        public Image Image { get; }

        public string Description { get; }

        public abstract int Run(int input1, int input2);
        
    }
}
