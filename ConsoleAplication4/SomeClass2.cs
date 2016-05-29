using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAplication4
{
    public class SomeClass2
    {
        public SomeClass2() { }
        public SomeClass2(string message1, int message2)
        {
            Message1 = message1;
            Message2 = message2;
        }
        [Colour()]
        public string Message1 { get; set; }
        [Colour("cyan")]
        public int Message2 { get; set; }
    }
}
