using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightWatchers
{
    //Created by Nimmala
    //11111111111111111
    public class Exercise
    {
        public double CaloriesBurnt(int minutes)
        {
            //Calories burnt =Duration in (mins)*(MET*3.5*Weight in kg)/200
            //Considering MET=2.5, weight=185 lbs(83 kg)
            return minutes * 2.5 * 3.5 * 83 / 200;

        }
        public double CaloriesBurned(int activity,double weight, int duration)
        {
            //This is an overloaded method

            double[] metArray = { 2.5, 2.5, 2.9, 4.5, 6.0, 7.0, 8.0, 8.0, 10.0 };

            //Total calories burned=Duration(mins)*(MET*3.5*weight in kg)/200

            return duration * metArray[activity] * ConvertToKilogram(weight) / 200;
        } // End of calories burned
        public double ConvertToKilogram(double pounds)
        {
            return pounds * 0.45359237;// kg=lb*0.45359237
        }// end of method lb to Kg conversion
    }// End of Exercise
    /*
     * Yoga 2.5
     * Waliking, 2mph 2.5
     * Dancing, ballroom, slow 2.9
     * Swimming, Moderate pace 4.5
     * Shoveling snow 6
     * Tennis 7.0
     * Jogging, 12 min/mile 8.0
     * Bicycling, 12-13 mph 8.0
     * Running, 10  in/mile 10.0
     * Exercise calories=(MET level of activity*3.5*weight(kg)*0.453*minutes of activity)/200
     * Energy Expenditure (calories/min)=0.0175*MET*weight(kg)
     */ 
}//End of Namesapce
