using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTax
{
    //Created by Nimmla
    //11111111111111111
    public class TaxClass
    {
        private const decimal TAX_RATE_DECIMAL = 0.0135m;
        //m-Decimal,D-double, L-long, s-Short, F-Float

        public decimal CalculateTax(decimal propertyValue)
        {
            return propertyValue* TAX_RATE_DECIMAL;
        }

    }
}
