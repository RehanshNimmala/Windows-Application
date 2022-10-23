using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoAndContraVariances
{
    //Created by Nimmala
    //1111111111111111
    public class Animal
    {
        private string animalName;
        public Animal(string aName)
        {
            AnimalName = aName;
        }//end of ctor

        public string AnimalName
        {
            get { return animalName; }
            set { animalName = value; }
        }//End property AnimalName
    }//end class animal
}//End Namespace
