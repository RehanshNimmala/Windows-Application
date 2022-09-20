using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //Created by Nimmala
    //33333333333333333
     class ClassRectangle:ClassShape
    {
        public ClassRectangle(int length, int width) : base(length, width)
        {

        }
        public ClassRectangle(int length): base(length, length)
        {
            // overloaded ctor for Square
        }
        public new string Draw()
        {
            if (base.XPosition == base.YPosition)
                return $@"Drawing a square:Length{XPosition}.{Environment.NewLine}
                    Square is a rectangle with equal sides.Output from Rectangle Class.
                    {Environment.NewLine} Draw() method of rectangle class hides the base class method.
             {Environment.NewLine}The Rectangle Class ctor has overloaded constructors:one for square and other for Rectangle";
            else
                return $@"Drawing rectangle:X{XPosition},Y:{YPosition}.
                {Environment.NewLine}Output from Rectangle class.
                {Environment.NewLine}Draw() method of rectangle class hides the base class method";                    
        }
    }//End class rectangle
}//End Namespace
