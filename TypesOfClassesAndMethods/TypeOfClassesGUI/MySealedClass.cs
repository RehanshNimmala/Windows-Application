using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfClassesGUI
{
    public sealed class MySealedClass
    {
        public override string ToString()
        {
            return $"A sealed class can't be inherited by another class\r\n You can only use the class by instantiating";
        }
        public string ShowDetails()
        {
            return $"Name of this object is: {this.GetType().Name}";
        }
    }
}
