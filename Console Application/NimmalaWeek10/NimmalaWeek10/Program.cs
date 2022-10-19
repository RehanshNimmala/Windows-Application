using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmalaWeek10
{
    internal class Program
    {
        //Created by Nimmala
        delegate void MyFirstDelegate(String s);
        delegate void MySquareDelegate(int sq);

        static void Main(string[] args)
        {
            //Initialize the delegate with a name method that has same signature as the delegate

            MyFirstDelegate myDelegate = new MyFirstDelegate(WriteToConsole);
            MyFirstDelegate myDelegate2 = new MyFirstDelegate(WriteToConsole2);

            //A delegate can be initialized with an anonymous method with the same signature as the delegate

            MyFirstDelegate myDelegateAnon = delegate (String s)
            {
                Console.WriteLine(s);
                Console.WriteLine("----------");
                Console.WriteLine();

            };
            //Delegate with lambda expression
            MyFirstDelegate myDelegateLambda = (s) =>
            {
                Console.WriteLine(s);
                Console.WriteLine("----------");
                Console.WriteLine();

            };
            MySquareDelegate mySquareDelegate = new MySquareDelegate(FindSquare);

            //call /invole the delegates:
            myDelegate("Hello from Naveen-myDelegate");
            myDelegate2("How are you--myDelegate2");
            myDelegateAnon("Hello from Anonymous Delegate");
            myDelegateLambda("Hello from lambda");
            mySquareDelegate(100);

            //multicast delegate

            var myMulticastdelegate = myDelegate + myDelegate2;
            myMulticastdelegate("Hello from multicast delegate");

            //creating and usinf a lambda

            List<string> myList = new List<string>();

            myDelegate($"Enter input to create list and find the word/input smallest number of letter using lambdaexpression:Press Enter to Continue and Escape to Exit");

            //loop to accept the numbers for list
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                //add numbers entered to list:
                myList.Add(Console.ReadLine());
                myDelegate("Press Enter to continue and Escape to Exit");
            }//end while
            

            //finnd the smallest word using lambdaexpression

            int smallestWordLength = myList.Min(smallest => smallest.Length);
            string smallestWord = myList.Find(s => s.Length == smallestWordLength);

            //find the longest word
            string longestWord = myList.Find(longest => longest.Length == myList.Max(l => l.Length));


            //Write output
            myDelegate($"The smallest word is {smallestWord} with a length of {smallestWordLength}");
            myDelegate($"The longest word is {longestWord}");
            Console.ReadLine();
        

        }

        //methods used
        public static void WriteToConsole(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("-----------");
            Console.WriteLine();
        }
        public static void FindSquare(int inputNumber)
        {
            Console.WriteLine($"square of {inputNumber}is {Math.Pow(inputNumber, 2)}");
            Console.WriteLine("-----------");
            Console.WriteLine();

        }
        public static void WriteToConsole2(string message)
        {
            Console.WriteLine($"this is console.WriteLine2 method { message.ToUpper()}");
            Console.WriteLine("-----------");
            Console.WriteLine();

        }
    }
}
 