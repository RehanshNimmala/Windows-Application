using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfClassesGUI
{
    public class MyBaseClass
    {
        protected string _MyName;
        public MyBaseClass(string name)
        {
            _MyName = name;
        }

        public virtual string ShowDetails
        {
            get
            {
                return $"The value of name field in this object is {_MyName}.{Environment.NewLine}This is the parent class for MyDerivedClass.{Environment.NewLine}Do base class can have other base (or parent classes too).{Environment.NewLine}This Class (and all classes in c#) are derived from : {this.GetType().BaseType}{Environment.NewLine}All the methods and properties inherited by base class from its parent class are passed on by inheritance to its child classes";
            }
        }
        public override string ToString()
        {
            return $"A base class is a class that is used to create, or derive, other cvlasses. \r\nA base does not from any other class and is considered parent of a derived class.\r\nBase classes are automatically instanciated before derived classes.";
        }
    }
}
