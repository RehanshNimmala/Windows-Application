using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Name");
            string myName=Console.ReadLine();
            Console.WriteLine("Please Enter your Age");

            string myAge =Console.ReadLine();
            Welcome welcome=new Welcome(myName);
            Welcome awelcome = new Welcome(myAge);

            Console.ReadKey();

        }
        public class Welcome
        {
            public Welcome(string name)
            {
                Console.WriteLine($"Welcome {name}");
            }
        }
    }
}
