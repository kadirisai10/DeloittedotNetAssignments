using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace ExtensionExample
{
    static class ExtendMultiply
    {
        public static int mul(this Calculator c ,int x, int y)
        {
            return (x * y);
        }
    }
}
