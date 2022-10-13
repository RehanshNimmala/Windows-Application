using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace NimmalaWeek9
{
    //55555555555555555
    internal class OverloadedMethodsClass
    {
        public void MyMethod(int myInt)
        {
            string message = $"My method signature:{MethodBase.GetCurrentMethod().ToString()}\r\n";
            message+=$"\r\n Is this a Generic Method?{MethodBase.GetCurrentMethod().IsGenericMethod}\r\n";
            message+=$"Value of incoming parameter is:{myInt}";
            Consolator.WriteToConsole(message);


        }//MyMethod-int.1
        public void MyMethod(int myInt, bool myBool)
        {
            string message = $"My method signature:{MethodBase.GetCurrentMethod().ToString()}\r\n";
            message += $"\r\n Is this a Generic Method?{MethodBase.GetCurrentMethod().IsGenericMethod}\r\n";
            message += $"Value of incoming parameters are:{myInt} and {myBool}";
            Consolator.WriteToConsole(message);

        }//MyMethod int.bool2
        public void MyMethod<T>(T para1)
        {
            string message = $"My method signature:{MethodBase.GetCurrentMethod().ToString()}\r\n";
            message += $"\r\n Is this a Generic Method?{MethodBase.GetCurrentMethod().IsGenericMethod}\r\n";
            message += $"Incoming parameter type is:{para1.GetType().Name}{para1.ToString()}";
            Consolator.WriteToConsole(message);
        }//MyMethod 3

        public void MyMethod<T>(T para1,T para2)
        {
            string message = $"My method signature:{MethodBase.GetCurrentMethod().ToString()}\r\n";
            message += $"\r\n Is this a Generic Method?{MethodBase.GetCurrentMethod().IsGenericMethod}\r\n";
            message += $"Incoming parameter details:{para1.ToString()}{para2.ToString()}";
            Consolator.WriteToConsole(message);

        }//MyMethod4

        public void MyMethod<T1,T2>(T1 para1, T2 para2)
        {
            string message = $"My method signature:{MethodBase.GetCurrentMethod().ToString()}\r\n";
            message += $"\r\n Is this a Generic Method?{MethodBase.GetCurrentMethod().IsGenericMethod}\r\n";
            message += $"Incoming parameter details:{para1.ToString()}{para2.ToString()}";
            Consolator.WriteToConsole(message);
        }//MyMethod5
    }//OverloadedMethodClass
}//Namespace
