using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfClassesGUI
{
    public abstract class MyAbstractClass
    {
        public String _MyField;
        public MyAbstractClass()
        {
            _MyField = $"You are now accessing a field from MyAbsrtractClass called _MyField. This was set in the constructor for {this.GetType().Name}";
        }
        public string MyMethod()
        {
            return $"The name of this object is : {this.GetType().Name}Abstract only has implementation inheritance.You cannot instantiate an Abstract Class.You can only derive other classes out of abstract class.";
        }
        public abstract string AbstractShowDetails();

        public override string ToString()
        {
            return "The abstract modifier indicates that the thing being modified has a missing or incomplete implementation. Use the abstract modifier in a class declaration to indoicate that a class is intended only to be a base class of other classes, not instantiated on its own.";
        }
    }
}
