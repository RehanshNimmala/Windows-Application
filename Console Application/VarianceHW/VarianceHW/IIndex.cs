using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceHW
{
    //creted by Nimmala
    //111111111111
    //Covariant Interface
    //Covariance enables you to use a more derived type than originally specified.
  interface IIndex<out T>
    {
        T this[int index] { get;}
        int count { get; }
    }
}
