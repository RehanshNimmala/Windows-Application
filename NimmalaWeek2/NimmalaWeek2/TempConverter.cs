using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmalaWeek2
{
    public class TempConverter
    {
        public decimal FtoC(decimal farenhiet)
        {
            decimal result ;
            // Formula:C=5/9*(F-32)

            result=( (decimal)5 /(decimal) 9) * (farenhiet - 32);
            return result;
        }// end of FtoC method

        public decimal CtoF(decimal celcius)
        {
            decimal result;
            //Formula: F=C*(9/5)+32
            result= celcius * ((decimal)9 /(decimal) 5) + 32;
            return result;
        }// end of Cto F method
    }// End of TempConverter class
}//End of Namespace
