using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleForm
{
    // Created by Nimmala
    //2222222222222222222222
     class Vehicle : IDrivable
    {
        /*
         * This class is derived from IDrivable Interface
         * This class implements one property and one method from the interface with two additional properties.
         * Has three properties, one constuctor, one virtual overloaded method.
         */
        //Private variable fields
        private int numberOfWheels;
        private double maximumSpeed;
        private string color;
        private string about;

        //Constructor:
        public  Vehicle(int numWheels,double maxSpeed,string color)
        {
            // Receive the incoming argumnents and set the fields
            numberOfWheels = numWheels;
            maximumSpeed = maxSpeed;
            color = color;

        }// End of Constructor
        public double MaximumSpeed
        {

        }

    }
    
    
    
}
