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
            SomeClass s1 = new SomeClass();
            SomeClass2 s2 = new SomeClass2();
            ColourP c = new ColourP();

            Console.WriteLine("SomeClass1");
            s1.message1 = "qwe";
            s1.message2 = '1';
            c.ColourPrint(s1);
   
            Console.WriteLine();

            Console.WriteLine("SomeClass2");
            s2.message1 = "asd";
            s2.message2 = 123;
            c.ColourPrint(s2);
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ColourAttribute : System.Attribute
    {
        public ColourAttribute() { }
    }

    public class SomeClass
    {
        [Colour()]
        public string message1 { get; set; }
        [Colour()]
        public char message2 { get; set; }
    }

    public class SomeClass2
    {
        public string message1 { get; set; }
        [Colour()]
        public int message2 { get; set; }
    }

    public class ColourP
    {
        public void ColourPrint(object obj)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Type t = obj.GetType();
            foreach (PropertyInfo p in t.GetProperties())
            {
                foreach (var Attribute in p.CustomAttributes)
                {
                    if (Attribute.AttributeType.ToString() == "ConsoleAplication4.ColourAttribute")
                    {
                        Console.WriteLine(p.GetValue(obj));
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}
