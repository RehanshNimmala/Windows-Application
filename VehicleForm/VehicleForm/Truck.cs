using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleForm
{
    //Created by NImmala
    //5555555555555555555
    /*This derived class has its own axle weight property which is specific to trucks*/
     class Truck: Vehicle
    {
        //constant members
        private const int WHEELS = 18;
        private const int MAX_SPEED = 70;
        private const string TRUCK_COLOR = "RED";
        private int axleWeight;

        /* Regular way of defing constructor
         * public Truck(int weightPerAxle):base(WHEELS,MAX_SPEED<TRUCK_COLOR)
         * {
         * axleWeight=weightPerAxle;
         * }*/
        // Expression baased constructor C#7.0
        public Truck(int weightPerAxle):base(WHEELS,MAX_SPEED,TRUCK_COLOR)=>axleWeight = weightPerAxle;

        public int AxleWeight
        {
            //Expression bodied property with getter and setter C#7.0
            get => axleWeight;
            set => axleWeight = value;
        }// Property
    }//Truck Class
}//namespace
