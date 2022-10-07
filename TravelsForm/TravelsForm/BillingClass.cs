using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelsForm
{
    public class BillingClass : IBilling
    {
        private int travelers;
        private const decimal FIRST_CLASS = 2400m;
        private const decimal ECONOMY = 800m;
        public BillingClass(int numberOfTravelers)
        {
            travelers = numberOfTravelers;
        }
        public int Travelers
        {
            get { return travelers; }
            set { travelers = value; }
        }
        public decimal CalculateDue(int travelClass)
        {
            decimal amountDue;
            switch (travelClass)
            {
                case 2:
                    amountDue = FIRST_CLASS*this.Travelers;
                    break;
                default:
                    amountDue = ECONOMY*this.Travelers;
                    break;
            }
            return amountDue;
        }
    }
}
