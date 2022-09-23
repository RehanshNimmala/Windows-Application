using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    //Created by Nimmala
    //222222222222222222
     class Program
    {
        static void Main(string[] args)
        {
            int myIntNumber = 20;//unboxed
            //Boxing -convert value type to a reference type
            object boxedInteger = myIntNumber;
            //boxed integer, is an Object type, and therefore reference type
            //Unboxing -Convert back to a reference type
            int unBoxedInteger=(int)boxedInteger;
            Consolator.WriteToConsole($"UnboxedInteger: By reference to another variable):{unBoxedInteger}");

            //Example: Boxing and Unboxing integers in an ArrayList

            var boxedList=new System.Collections.ArrayList();
            boxedList.Add(64);//(boxing--(list is an object--reference type)

            int unBoxedIntegerFromList = (int)boxedList[0];// casting--Unboxing
            Consolator.WriteToConsole($"Unboxing:unboxedIntegerFromList:{unBoxedIntegerFromList}");

            //lets add more list items(you will need to add value types to the list and box them as reference types-More boxing)
            boxedList.Add(44);
            boxedList.Add(55);
            boxedList.Add(55);

            foreach(int integerFromList in boxedList)
            {
                Consolator.WriteToConsole($"Unboxing: integerFromList from foreachloop:{integerFromList}");//unboxing

            }//end of each
            Consolator.WriteToConsole($@"Moral of the story is:Boxing and Unboxing are straight forward.But..
                                {Environment.NewLine})...comes with a price:Perfromance.{Environment.NewLine}
                            Generics avoids theneed to use objects, and boxing/unboxing.{Environment.NewLine}
                            Generics allow to define the specific type when it is used");

            //-----Now using the generic list object
            var genericList=new System.Collections.Generic.List<int>();
            genericList.Add(44);//no boxing-value types are stored in List<T>
            genericList.Add(55);
            genericList.Add(65);
            genericList.Add(75);

            int intFromList = genericList[0];// no unboxing, no cast needed
            Console.WriteLine($"int intFromList=genericList[0);" +
                $"// no unboxing no cast needed: Value of intFromList is:{intFromList}(Better for performance)");
            //Loop through the generic list and display the values
            foreach(int integerFromList in genericList)
            {
                Consolator.WriteToConsole($"Looping through generic list: no unboxing needed.{integerFromList}");// no unboxing 
            }// foreach


        }//Main method
    }//Program class
}//Namespace

