using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceHW
{
    /*Created by Nimmala
      * 6666666666666666666*/

    class ShapeDisplay : IDisplay<Shape>
    {
        //IDisplay is contravariant.Covariant type parameters are defined with out parameter and can only be used as return types and property get accessor types.
        //Show method writes the type, and width and height properties of the shape object supplied as a parameter.
        //In this case acessing the width and height properties of the shape parameter ssupplied.

        public void Show(Shape s) => Console.WriteLine($"{s.GetType().Name} Width:{s.Width}, Height: {s.Height}");
    }//shape
}
