using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWrite rw = new ReadWrite();
           // rw.WriteFile("c:\\FILES\\Test.txt");

            rw.ReadFile("c:\\FILES\\Test.txt");
        }
    }
}
