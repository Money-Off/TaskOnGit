using System;
using System.Collections.Generic;
using System.Linq;

namespace lib
{
    public static class Plugins
    {             

        static List<IPlugin> plugins = new List<IPlugin>() { new Sum(), new Sub(), new Multi(), new Div() };
        /// <summary>
        /// Количество всех операций
        /// </summary>
        public static int PluginsCount { get=>plugins.Count; }
        /// <summary>
        /// Имена всех операций
        /// </summary>
        public static string[] GetPluginNames { get=>plugins.Select(plugin=>plugin.PluginName).ToArray(); }
        /// <summary>
        /// Выбор операции: Сложение, Вычитание, Умножение или Деление
        /// 
        /// <para>Исключения: <br></br>System.DivideByZeroException, System.NullReferenceException</para>
        /// </summary>
        /// <param name="pluginName"></param>
        /// <returns></returns>
        public static IPlugin GetPlugin(string pluginName)
        {
            var a=plugins.Find(plugin => plugin.PluginName == pluginName);
            if (a == null)
            {
                Console.WriteLine("Такой команды нет!");
                throw new NullReferenceException();
            }
            return a;
        }
    }
}
