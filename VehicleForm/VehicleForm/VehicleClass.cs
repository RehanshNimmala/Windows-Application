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
            get { return maximumSpeed; }
            set { maximumSpeed = value; }

        }// end prop MaximimSpeed
        public int NumberOfWheels
        {
            get { return numberOfWheels; }
            set { numberOfWheels = value; }
        }//End prop NumberOfWheels
        public string Color
        {
            get { return color; }
            set { color = value; }
        }// End prop color

        public virtual string Drive(double distance, double speedLimit)
        {
            // This is an virtual method that can be overridden in derived classes
            //Receives distance and speed limit, calculates and returns the time taken to cover the distance
            //highest speed of the vehicle will be the lower of maximum speed travelled by the vehicle ot te speed limit
            //uses another method to do the calculation of time

            double highestSpeed = maximumSpeed > speedLimit ? speedLimit : maximumSpeed;
            //(highest speed will be the lower of:speed limit or MaximumSpeed)
            double hoursDriven = this.CalculateTimeDriven(distance, highestSpeed);
            return $"{distance} miles driven in {hoursDriven}hours at {highestSpeed} miles per hour.";
        }// End Drive()
        public string About
        {
            get
            {  about =$@"This class has four properties: Details, Color, NumberOfWheels, MaxSpeed.
            MaxSpeed is the legal speedlimit.{Environment.NewLine}.This class has virtual overloaded method Drive with
            two signatures to calculate time taken to travel a distance.(distance) and (distanceSpeed).
            When speed is not supplied, max speed is taken for calculation of time taken.
            When speed is supplied, it takes the lower of MaxSpeed or speed supplied as argument.";
                return about;
            }//get
        }//About
        public virtual string Drive(double distance)
        {
            return Drive(distance,MaximumSpeed);// this is using the drive method and maximum speed property.
            //This method would be used for vehicles,that do not care about the speed limit such as race cars while racing.
        }// End Drive()
        protected double CalculateTimeDriven(double distanceDriven,double speed)
        {
            // will be visible on to this class and the classes derived from this class.
            return distanceDriven / speed;
        }//End method

        //tostring Override method to give details about the vehicle class.(to string method is based on the system.object. 
        // but, overridden in this class to customize the class information
        public override string ToString()
        {
            return $@"Type of vehicle:{GetType().Name}{Environment.NewLine}Vehicle Color:{color}{Environment.NewLine}
                    MaximumSpeed:{maximumSpeed}{Environment.NewLine}Number of Wheels{numberOfWheels}";
            /* GetType also belongs to the system.object and is an example of reflection.
             * where you read the internal code for getting information*/
        }// End ToString()
        //Expression bodied method
        private string ObjName()=>this.GetType().Name;
    }//End class
      
}//End Namespace
