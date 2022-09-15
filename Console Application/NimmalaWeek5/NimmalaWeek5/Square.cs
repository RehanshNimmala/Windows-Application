using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmalaWeek5
{
    //Created by Nimmala
    //3333333333333333333333
     class Square:Shape
    {
        public Square(int xInt):base(xInt,xInt)
        {

        }// End constructor
        public new void Draw()
        {
            /*This method haas the same name as the method Draw() in the base class, but does not override the base class method.
             * This is permitted.But New key word to be used.
             * When the derived class haas a method that has the same name as the base class with a new keyword
             * ( but NOT override method)the base class.Then, the base class method is Hidden by the derived class method 
             * with the same name*/
            Console.WriteLine("Drawing a Square at position {0},{1}.OUTPUT from Square Class.",XPosition,YPosition);
        }// End of Draw()
    }
}
