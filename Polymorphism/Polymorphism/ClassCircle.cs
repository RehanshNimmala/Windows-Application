using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //Created by Nimmala
    //4444444444444444444
    public class ClassCircle:ClassShape
    {
        public ClassCircle(int x, int y):base(x,y)
        {

        }//end ctor
        public string FillColor(string color)
        {
            return $@"Fill Circle with color{color}{Environment.NewLine}Output from CircleClass";
        }//End FillColor()
    }//end classCircle
   
}//end namespace
