using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAplication4
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColourAttribute : Attribute
    {
        public int ColourIndex { get; set; }
        public ColourAttribute()
        {
            ColourIndex = 9;
        }
        public ColourAttribute(string ColourName)
        {
            switch (ColourName.ToLower())
            {
                case "black":
                    ColourIndex = 0;
                    break;
                case "darkblue":
                    ColourIndex = 1;
                    break;
                case "darkgreen":
                    ColourIndex = 2;
                    break;
                case "darkcyan":
                    ColourIndex = 3;
                    break;
                case "DarkRed":
                    ColourIndex = 4;
                    break;
                case "darkmagenta":
                    ColourIndex = 5;
                    break;
                case "darkyellow":
                    ColourIndex = 6;
                    break;
                case "gray":
                    ColourIndex = 7;
                    break;
                case "darkgray":
                    ColourIndex = 8;
                    break;
                case "blue":
                    ColourIndex = 9;
                    break;
                case "green":
                    ColourIndex = 10;
                    break;
                case "cyan":
                    ColourIndex = 11;
                    break;
                case "red":
                    ColourIndex = 12;
                    break;
                case "magenta":
                    ColourIndex = 13;
                    break;
                case "yellow":
                    ColourIndex = 14;
                    break;
                default:
                    ColourIndex = 15;
                    break;
            }
        }
    }
}
