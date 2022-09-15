using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmalaWeek5
{
    // Created by Nimmala
    //22222222222222222222
    public class Circle:Shape
    {
        public Circle()
        {

        }
        public Circle(int xInt,int yInt):base(xInt,yInt)
        {

        }// End of Constructor
        public new void Draw()
        {
            Console.WriteLine("Drawing a circle at position:{0},{1}",XPosition,YPosition);
        }
        public void FillColor(string colorString)
        {
            Console.WriteLine("Filling circle with color {0}",colorString);
        }
    }
}
