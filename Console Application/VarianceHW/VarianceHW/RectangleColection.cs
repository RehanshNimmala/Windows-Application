using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceHW
{
    internal class RectangleCollection : IIndex<Rectangle>
    {
        //Created by Nimmala
        //55555555555555555

        //IIndex is covatiant
        //Covariance enables you to  use a more derived type than originally specified.

        private Rectangle[] data = new Rectangle[3]
        {
            new Rectangle { Height = 2, Width = 5 },
            new Rectangle { Height = 3, Width = 7 },
            new Rectangle   { Height = 4.5, Width = 2.9 }

        };
        private static RectangleCollection coll;
        public static RectangleCollection getRectangles() => coll ?? (coll = new RectangleCollection());
        //?? is null coalescing operator: returns the value of its left-hand operand if it isn't null;
        //otherwise it evaluates the right hand operand 
        public Rectangle this[int index]
        {
            get
            {
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                return data[index];
            }//end get
        }// end prop

        public int Count => data.Length;

        //public int count => throw new NotImplementedException();
    }
}
