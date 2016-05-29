using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAplication4
{
    public class ColourPrint
    {
        public void CP(object Class)
        {
            Type ClassType = Class.GetType();
            foreach (PropertyInfo Property in ClassType.GetProperties())
            {
                Type PropertyType = Property.GetType();
                object[] Attributes = Property.GetCustomAttributes(true);
                foreach (ColourAttribute Attribute in Attributes)
                {
                    Console.ForegroundColor = (ConsoleColor)Attribute.ColourIndex;
                    Console.WriteLine(Property.GetValue(Class));
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
