using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleForm
{
    //Created by NImmala
   // 333333333333333333333333
     class RaceCar:Vehicle
        /*Race car is also a car just like the vehicle class and derives all methods and properties from the parent class
         * However Race car is different because: it has a Race car type(vehicle class doesnot), and is not subject to
         * speedLimt whhile racing.(Normal car is subjected to speed limits all the times)
         * */
    {
        public enum RaceCarType
        {
            Formula,Rally, Drift, Stock
        }//End enum
        private RaceCarType raceCarType;
        //Constructor:
        public RaceCar(double maxSpeed, string color, RaceCarType type):base(4,maxSpeed,color)
            //constructor is using the parent class ctor and supplying the arguments to it
        {
            raceCarType = type;// setting the property
        }//End ctor
        public override string Drive(double distance, double speedLimit)
        {
            //this method overrides the virtual method drive in parent class
            double hoursDriven = CalculateTimeDriven(distance, MaximumSpeed);
            // becoz this is a racer car, this method bypasses the speed limit imposed by the virtual method in parent class
            String speeding = MaximumSpeed > speedLimit ? "While Racing" : "Race Car within Speed Limit";
            /* If car overspeed limit, it just means it is racing which is what a race car would do! this variable is used
             * as add1.Info while returning value.
             */
            return $"{distance}miles driven in {hoursDriven} hours at {MaximumSpeed}MPH{speeding}";
            //Because you override the method from the base class, all the overloaded methods are overridden.

        }// end overriding method Drive().
        public override string ToString()
        {
            return base.ToString()+$"Racing Type={raceCarType.ToString()}";
        }


    }//End race car class
}//End Namespace
