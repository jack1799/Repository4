using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAplication4
{
    public class SomeClass1
    {
        public SomeClass1() {}
        public SomeClass1(string message1, char message2)
        {
            Message1 = message1;
            Message2 = message2;
        }
        [Colour("yellow")]
        public string Message1 { get; set; }
        [Colour("magenta")]
        public char Message2 { get; set; }
    }
}
