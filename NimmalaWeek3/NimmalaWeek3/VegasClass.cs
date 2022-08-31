using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Created by Nimmala 
namespace NimmalaWeek3
{
    public class VegasClass
    {
        public int Roll(out int die1,out int die2)
        {
            //This method generates two random numbers for the two incoming parameters and returns the total.

            //Instantiate Random:
            Random random = new Random();
            //Generate and assign to Die1 and Die2
            die1 = random.Next(1, 7);
            die2 = random.Next(1, 7);

            //return the sum of die1 and die2

            return die1 + die2;


        }// End Roll
    }//End Class
}//End Namespace
