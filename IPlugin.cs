using System;
using System.Collections.Generic;
using System.Text;

namespace lib
{
    public interface IPlugin
    {
        string PluginName { get; }
        string Version { get; }
        System.Drawing.Image Image { get; }
        string Description { get; }
        /// <summary>
        /// Запуск выбранной операции
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        int Run(int input1, int input2);
    }
}
