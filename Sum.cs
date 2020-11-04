using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace lib
{
    internal class Sum : PluginBase
    {
        public Sum() : base("Сложение", "1.0.1", "Сложение первого числа и второго")
        {

        }
        
        override public int Run(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}
