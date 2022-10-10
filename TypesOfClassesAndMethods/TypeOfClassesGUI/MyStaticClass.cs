using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfClassesGUI
{
    public static class MyStaticClass
    {
        public static string StaticShowDetails()
        {
            return $"The name of this object is: MyStaticClass object.{Environment.NewLine}Cannot have instance members.{Environment.NewLine}Can be called directly without instantiating.";
        }
        public static string ToString() => $"Static classes are sealed and therefore cannot be inherited.\r\nIn other words, you cannot use the new operator to create a variable of the class type. They Cannot inherit from any class except Object. static classes cannot contain an instance constructor";
    }
}
