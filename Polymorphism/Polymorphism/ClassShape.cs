using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //Created by Nimmala
    //22222222222222222222
    public class ClassShape:IPolyShapes
    {
        protected int XPosition;
        protected int YPosition;

        //ctor
        public ClassShape(int x, int y)
        {
            XPosition = x;
            YPosition = y;
        }// end ctor
        public string Draw()
        {
            return $"Drawing Shape at position X:{XPosition},Y:{YPosition}.{Environment.NewLine} Output from Shape Class.";
        }//End Draw()

    }//End ClassShape
}//End Namespace
