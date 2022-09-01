using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollDiceConsole
    //Make the project refernece to Nimmala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class from Nimmala Project
            NimmalaWeek3.VegasClass vegasClass = new NimmalaWeek3.VegasClass();
            // Declaring the variables
            int dice1;
            int dice2;
            int sumOfDice;
            do
            {
                sumOfDice = vegasClass.Roll(out dice1, out dice2);
                Console.WriteLine($@"Die 1={dice1} Die2={dice2} Total Value={sumOfDice}");
                Console.WriteLine("Press any key to continue.Press <ESC> to exit");

            }
            while (Console.ReadKey().Key!=ConsoleKey.Escape);
           

            
        }
    }
}
