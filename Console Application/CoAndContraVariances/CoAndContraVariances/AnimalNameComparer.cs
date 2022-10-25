using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoAndContraVariances
{
    /* created by Nimmala
     * 3333333333333333*/
    public  class AnimalNameComparer:IComparer<Animal>
    {
        /* IComparer<T> interface defines a method that a type implements to compare two objects
         * public interface IComparer <in T>
         * In order to compare the objects must be similar--such as base and derived classes
        */
        public int Compare(Animal animalx, Animal animaly)
        {
            return animalx.AnimalName.Length.CompareTo(animaly.AnimalName.Length);
        }//end compare
    }//end class
}//end Namespace
