using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleForm
{
    //Created by Nimmala
    //444444444444444444
        class MotorCycle : Vehicle
    {
        /*Motor cycle is also a vehicle just like the vehicle class and derives all methods and properties from the 
         * parent class.However motor cycle is different because: it has only two wheels.
         * For the purpose of our example: motor cycle is always supposed to be black
         */
        private const int NO_OF_WHEELS = 2;
        private const string MC_COLOR = "BLACK";

        public MotorCycle(double maxSpeed) : base(NO_OF_WHEELS, maxSpeed, MC_COLOR)//calling the base class ctor&
                                                                                   //supplying the arguments
        {
           //no code statements needed here.Base class will take care of this. 
        }// end ctor
    }//end MotorCycleClass
    
}//End Namespace
