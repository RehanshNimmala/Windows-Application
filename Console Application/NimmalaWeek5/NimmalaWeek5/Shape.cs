using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmalaWeek5
{
    //Created by Nimmala
    //111111111111111111
    public class Shape
    {
        protected int XPosition;
        protected int YPosition;

        public Shape()
        {

        }// End of Constructor
        public Shape(int xInt,int yint)
        {
            XPosition = xInt;
            YPosition = yint;
        }
        public void Draw()
        {
            Console.WriteLine("Drawing shape at position:{0},{1}.Output From Shape class.",XPosition,YPosition);
        }
    }
}
