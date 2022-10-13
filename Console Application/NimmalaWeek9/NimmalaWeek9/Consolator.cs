using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmalaWeek9
{
    internal class Consolator
    {
        //created by Nimmala
        //11111111111111
        public static void WriteToConsole(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue");
            Console.WriteLine();
            Console.ReadKey();
        }//method
    }//Consolator
}//namespace
