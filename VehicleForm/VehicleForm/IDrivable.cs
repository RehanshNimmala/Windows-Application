using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleForm
{
   // Created by Nimmala
   //11111111111111111
    interface  IDrivable
    {
        //This interface has one property and one method that returns a string and accepts two arguments.

        double MaxSpeed { get; set; }
        string Drive(double distance, double speedLimit);
    }// end of interface
}//End of namespace
