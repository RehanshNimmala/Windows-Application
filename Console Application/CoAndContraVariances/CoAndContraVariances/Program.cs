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
            Console.WriteLine("Now printing from the array after.sort method:Contravariance");
            cows.Sort(new AnimalNameComparer());
            foreach(Cow cow in cows)
            {
                Console.WriteLine(cow.AnimalName);
            }
            Console.ReadKey();
            //Contravariance example
        }//end main

        static void ListAnimals(IEnumerable<Animal> animals)
        {
            //IEnumerable <T> interface is covariant with out keyword
            //Covariance permits a method to have derived return type than that defined by the generic type parameter of the interface.
            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
                Console.WriteLine(animal.AnimalName.ToString());
                //The default implementation of method To string of object returns a string representing namespace_name.object_class_name
                //Cows variable is of the type List<Cow> which supports the IEnumerable<cow> interface.
                //through covariance, you can pass this variable to a method that expects a paramater of the type IEnumerable<Animal>,
                //because cow is a derived type of Animal class.

            }//end foreach
        }//End ListAnimals
    }//End class
}//End namespace
