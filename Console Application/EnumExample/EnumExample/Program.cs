using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    // Created by Nimmala
    /*
     * Enum is a way of creating a type of your own alias for integers.
     * An Enumeration type (or enum type) is a value type defined by aset of named constants of the 
     * underlying integral numeric type.
     * By default, the associated constant values of enum numbers are of type 'int'.
     * They start by Zero, and increase by one following the definiton text order.
     * You can explicitily specify any other integral numeric type as underlying type of an enumeration type.
     * To define an enum type, use the enum keyword and specify the names of enum numbers.
     * If you call a specific enum number,it returns the underlying integer.
     * If you convert an integer to an enum it returns the name of the integer
     */
    public enum Pizza
    {
        Neapolitan,
        Chicago,
        NewYorkStyle,
        Sicilian,
        Greek,
        California

    }
     internal class Program
    {
        static void Main(string[] args)
        {
            Pizza myPizza = Pizza.NewYorkStyle;
            Consolator(myPizza.ToString());            //displays the value of Pizza



            //Integer value of Pizza
            Consolator($"Integer value of {myPizza}is {(int)myPizza}");

            // converting int to enum
            Pizza myPizza2 = (Pizza)3;
            Consolator($"value of myPizza2 is {myPizza2}");

            //Iterating through Enum and getting the values
            foreach(string i in Enum.GetNames(typeof(Pizza))) // typeof operator gets the system.Type of a type
            {
                Consolator($"{i}");
            }// end of foreach

        }// End Main

        static void Consolator(string message)
        {
            //using this method to print, so need not write the code multiple times
            Console.WriteLine(message);
            Console.WriteLine("----------Press Any Key to Continue....");//Displays the message
            Console.WriteLine();//readability
            Console.ReadKey();// Just stopping and waiting for nothing
        }// end of Consolator

    }// End of class 
}// End of Namespace
