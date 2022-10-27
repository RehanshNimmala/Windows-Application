using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoAndContraVariances
{
    //Created by Nimmala
    //4444444444444
     class Program
    {
        static void Main(string[] args)
        {
            List<Cow> cows = new List<Cow>();
            cows.Add(new Cow("Gertude"));
            cows.Add(new Cow("Esther"));
            cows.Add(new Cow("Philly"));
            cows.Add(new Cow("Tonto"));
            cows.Add(new Cow("Abby"));
            ListAnimals(cows);
            Console.ReadKey();
            Console.WriteLine("Original cows list before using contravariance class(AnimalLengthComparer) to sort:");
            foreach(Cow cow in cows)
            {
                Console.WriteLine(cow.AnimalName);
            }
            Console.ReadKey();
            Console.WriteLine("Now printing from the array after.sortmethod:Contravariance");
            cows.Sort(new AnimalNameLengthComparer());
            foreach(Cow cow in cows)
            {
                Console.WriteLine(cow.AnimalName);
            }
            Console.ReadKey();
            //Contravariance example
        }//end main
    }
}
