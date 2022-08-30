using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatherineCateringHW1
{

    public class CalculateBilling
    {
        // Declaring the variables
        const double primeRib = 25.95;
        const double chicken = 18.95;
        const double pasta = 12.95;
        const double openBar = 25.00;
        const double wine = 8.00;
        const double tax_Rate = 1.225 / 100;
        public double resultPrimeRib(int guests)
        {
          
            double result = guests * primeRib;
           // double tip = result * (20 / 100);
           // double tax = result * tax_Rate;
            //double amountDue =result+tip+tax;
            return result;

        }
        public double resultChicken(int guests)
        {
            double result = guests * chicken;
            double tip = result * (20 / 100);
            double tax = result * tax_Rate;
            double amountDue = result + tip + tax;
            return amountDue;
        }
            public double resultPasta(int guests)
        {
            double result = guests * pasta;
            double tip = result * (20 / 100);
            double tax = result * tax_Rate;
            double amountDue = result + tip + tax;
            return amountDue;
        }

    }
}
