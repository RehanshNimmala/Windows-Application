using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfClassesGUI
{
    public class MyDerivedClass: MyBaseClass
    {
        public MyDerivedClass(string name) : base(name)
        {
        }
        public override string ShowDetails
        {
            get
            {
                return $"Name of this object is {base._MyName} {Environment.NewLine}This output is from the ShowDetails overriden property in {this.GetType().Name}!{Environment.NewLine}The base class for {this.GetType().Name} is {this.GetType().BaseType}";
            }
        }

        public override string ToString()
        {
            return "Classes derived from a base class are called child classes,sub classes or derived classes. Members of a derived class can access the public,protected,internal and protected internal members of a base class.Due to the transitive nature of inheritance, although the derived class has only one base class, it inherits the members declared in the parent(s) of the base class.\r\nWhen derived class is instantiated, its base class constructor is automatically called";
        }




    }
}
