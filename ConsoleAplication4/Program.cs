using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            SomeClass1 s1 = new SomeClass1("qwe", '1');
            SomeClass2 s2 = new SomeClass2("asd", 123);
            ColourPrint c = new ColourPrint();

            Console.WriteLine("SomeClass1");
            c.CP(s1);

            Console.WriteLine();
   
            Console.WriteLine("SomeClass2");
            c.CP(s2);

            Console.WriteLine();
        }
    }
}
