using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfClassesGUI
{
    public class ImplementAbstractClass : MyAbstractClass
    {
        public override string AbstractShowDetails()
        {
            return $"This method is an implementattion of Abstract method called AbstractShowDetails(). Name is: {this.GetType().Name}{Environment.NewLine}The Base class that is being implemented by this object is {this.GetType().BaseType}{Environment.NewLine}An abstract class cannot be instantiated.{Environment.NewLine}";
        }
    }
}
