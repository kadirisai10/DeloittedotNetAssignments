using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;
namespace ExtensionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.add(12, 13));
            Console.WriteLine(c.sub(24, 12));
            Console.WriteLine(c.mul(4, 4)); 
        }
    }
}
