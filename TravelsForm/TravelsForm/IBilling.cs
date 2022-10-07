using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelsForm
{
    internal interface IBilling
    {
        int Travelers { get; set; }
        decimal CalculateDue(int travelClass);
    }
}
