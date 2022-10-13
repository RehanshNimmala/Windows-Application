using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmalaWeek9
{
    internal class MyObject3
    {
        //4444444444444444
        public string MyProperty { get; set; }
        public MyObject3(string name)
        {
            MyProperty = name;
        }
        public override string ToString()
        {
            return $"Im an object of type:{this.GetType().Name} and name is {this.MyProperty}";
        }
    }//class
}//namespace
