﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceHW
{
    //creted by Nimmala
    //222222222222
    //Contravariant
    interface IDisplay<in T>
    {
        //method
        void Show(T item);
    }
}
