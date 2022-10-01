using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListGeneric
{
    //11111111111111111111
    class LLNodeMarker<T>
    {
        /*This is the generic class which will create one node of any data type
         * Has two properties:Next and Prev, which are the pointers to the next/previous nodes*/
        public T ValueProperty { get; internal set; }
        public LLNodeMarker<T> NextNode { get; internal set; }
        public LLNodeMarker<T> PreviousNode { get; internal set; }

        //ctor
        public LLNodeMarker(T value)
        {
            this.ValueProperty = value;

        }//end ctor
    }//end class
}
