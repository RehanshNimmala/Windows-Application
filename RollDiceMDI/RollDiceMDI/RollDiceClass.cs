using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollDiceMDI
{
    //Created by Nimmala
    //1111111111111111111111
    //This class has  one method which generates two random numbers
    //Because RollDice method accepts arguments as incoming by reference, (out keyword does not even require the incoming
    //variablesto be initialized). the value of the die1 and die2 variables is automatically available to the calling
    //procedure, without even having to return the values.

     // Objective of this method is to demonstrate the OUT keyword, and passing byRef.

     class RollDiceClass
    {
        public int RollDice(out int die1, out int die2)
        {
            Random randomNumbers = new Random();
            die1 = randomNumbers.Next(1, 7);//(will be 6;7 is not exclusive)
            die2 = randomNumbers.Next(1, 7);
            return die1 + die2;
        }// end RollDice();
    }//end class
}//end Namespace
