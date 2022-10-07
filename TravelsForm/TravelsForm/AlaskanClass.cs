using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelsForm
{
    internal class AlaskanClass : BillingClass
    {
        private const decimal AL_ECOMNOMY = 2000m;
        public AlaskanClass(int travelers): base(travelers)
        {

        }
        public decimal CalculateDue()
        {
            return this.Travelers * AL_ECOMNOMY;
        }
    }
}
