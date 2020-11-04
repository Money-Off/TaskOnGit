using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace lib
{
    internal class Div : PluginBase
    {
        public Div() : base("Деление", "1.0.1", "Деление первого числа на второе без остатка")
        {

        }
        override public int Run(int input1, int input2)
        {
            if (input2 == 0)
            {
                Console.WriteLine("Деление на 0");
                throw new DivideByZeroException();
            }
            return input1 / input2;
        }
    }
}
