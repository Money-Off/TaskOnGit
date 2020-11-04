using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace lib
{
    internal class Multi : PluginBase
    {
        public Multi() : base("Умножение", "1.0.1", "Умножение первого числа второго")
        {

        }
        override public int Run(int input1, int input2)
        {
            return input1 * input2;
        }
    }
}
