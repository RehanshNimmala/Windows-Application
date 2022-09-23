using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    //Created by Nimmala
    //1111111111111111111
    public static class Consolator
    {
        public static void WriteToConsole(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("--------------Press any Key to continue");//Display the message
            Console.WriteLine();
            Console.ReadKey();//To stop

        }//End of WriteToConsole()
    }//End Consolator class
}//End Namespace
