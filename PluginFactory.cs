using System;
using System.Collections.Generic;
using System.Text;

namespace lib
{
    internal interface PluginFactory
    {
        int PluginsCount { get; }
        string[] GetPluginNames { get; }
        IPlugin GetPlugin(string pluginName);
    }
}
