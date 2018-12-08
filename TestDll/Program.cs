using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCalc;
namespace TestDll
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            Console.WriteLine(c.add(4, 4));
            Console.Read();
        }
    }
}
