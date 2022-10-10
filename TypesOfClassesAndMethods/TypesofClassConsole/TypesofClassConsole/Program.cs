using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeOfClassesGUI;

namespace TypesofClassConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Consolator.WriteToConsole("Created by Krushna Chinthada");
            Consolator.WriteToConsole("Welcome to my world",ConsoleColor.Cyan);
            Consolator.WriteToConsole(Consolator.MyObjectives,ConsoleColor.DarkYellow);

            MyBaseClass myBaseClass = new MyBaseClass("Krushna Chinthada");
            MyDerivedClass myDerivedClass = new MyDerivedClass("ch krushna");
            Consolator.WriteToConsole(myBaseClass.ToString(),ConsoleColor.Red);
            Consolator.WriteToConsole(myBaseClass.ShowDetails,ConsoleColor.Green);
            Consolator.WriteToConsole(myDerivedClass.ToString(),ConsoleColor.Magenta);
            Consolator.WriteToConsole(myDerivedClass.ShowDetails,ConsoleColor.Yellow);
            Consolator.WriteToConsole(MyStaticClass.ToString(),ConsoleColor.Green);
            Consolator.WriteToConsole(MyStaticClass.StaticShowDetails(), ConsoleColor.White);

            MySealedClass mySealedClass = new MySealedClass();
            Consolator.WriteToConsole(mySealedClass.ToString(), ConsoleColor.Magenta);
            Consolator.WriteToConsole(mySealedClass.ShowDetails(), ConsoleColor.Yellow);

            ImplementAbstractClass implementAbstractClass = new ImplementAbstractClass();

            string implementAbstractMessage = $"{implementAbstractClass.MyMethod()}{Environment.NewLine}{implementAbstractClass.AbstractShowDetails()}{Environment.NewLine}{implementAbstractClass._MyField}";
            Consolator.WriteToConsole(implementAbstractMessage.ToString(), ConsoleColor.Yellow);
            Consolator.WriteToConsole(implementAbstractMessage, ConsoleColor.Green);






        }
    }
    internal class Consolator
    {
        internal static void WriteToConsole(string message,ConsoleColor color)
        {
            Console.ForegroundColor=color;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine("_____________________Press any key to Continue_____________________");
            Console.WriteLine();
            Console.ReadLine();
        }
        internal static void WriteToConsole(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("_____________________Press any key to Continue_____________________");
            Console.WriteLine();
            Console.ReadLine();
        }
        public static string MyObjectives
        {
            get
            {
                return $"Objectives of this lab is to use multiple classes";
            }
        }
    }
}
