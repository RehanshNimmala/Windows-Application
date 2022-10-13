using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmalaWeek9
{
    //Created by Nimmala
    internal class Program
    {
        static void Main(string[] args)
        {
            Consolator.WriteToConsole("Generics-method specialization");
            OverloadedMethodsClass overloadedMethodsClass = new OverloadedMethodsClass();
            overloadedMethodsClass.MyMethod(1);
            overloadedMethodsClass.MyMethod(1, false);
            overloadedMethodsClass.MyMethod(new MyObject1());
            overloadedMethodsClass.MyMethod(new MyObject1(),new MyObject2());
            overloadedMethodsClass.MyMethod<string>("Naveen Nimmala");
            overloadedMethodsClass.MyMethod<MyObject1, MyObject3>(new MyObject1(), new MyObject3("Nimmala"));

        }//main
    }//program class
}//namespace
