using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmalaWeek6
{
    //Created by Nimmala
    //11111111111111111
    public class MyGenericClass<T>
    {
        public MyGenericClass(T[] inputArray)
        {
            genericProperty = inputArray;
        }
        private T[] genericProperty;
        public T[] GenericArray
        {
            get { return genericProperty; }
            set { genericProperty = value; }
        }
    }// End generic class
}//namespace

