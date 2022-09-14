using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferenceAndValueObjects
{
    //Created by Nimmala
    //111111111111111111
    public partial class ReferenceAndValueObjects : Form
    {
        //Form level variables
        static Random myRandom = new Random();
        // an integer with random number between 0 and 100
        private int byValueInt = myRandom.Next(0, 100);
        // An array with three random numbers
        private int[] byReferenceArray = { myRandom.Next(0, 20), myRandom.Next(30, 50), myRandom.Next(60, 80) };
        public ReferenceAndValueObjects()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }// end of exit button

        private void originalValueButton_Click(object sender, EventArgs e)
        {
            originalLabel.Text = $@"Original Values are:{Environment.NewLine}byValueInt:{byValueInt}
               {Environment.NewLine}byReferenceArray:[{byReferenceArray[0]},{byReferenceArray[1]}, {byReferenceArray[2]}]";
        }//Original Button 

        private void valuesAfterCallButton_Click(object sender, EventArgs e)
        {
            valuesAfterCallLabel.Text = $@"Values of variables in for form, after calling class are:
                {Environment.NewLine} byValueInt:{byValueInt}
                {Environment.NewLine} byReferenceArray:[{byReferenceArray[0]},{byReferenceArray[1]},{byReferenceArray[2]}]";

        }

        private void callClassButton_Click(object sender, EventArgs e)
        {
            ByValueAndByReference myValRef= new ByValueAndByReference();
            myValRef.ByReferenceMethod(byReferenceArray);
            myValRef.ByValueMethod(  byValueInt);
            MessageBox.Show($"ByValueReference class instantiated and /r/n ByReferenceMethod()" +
                " and ByValueMethod() called.","Class Instantiated",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }//end of CallClassButton
    }//end form code
        class ByValueAndByReference
        {
            public int ByValueMethod(int valueNumber)
            {
                return valueNumber =valueNumber* valueNumber;
            }// End method
            public void ByReferenceMethod(int[]referenceArray)
            {
                for (int i = 0; i < referenceArray.Length; i++)
                {
                    //square each element in the array
                    referenceArray[i] *=referenceArray[i];

                }
            }// end method ByRefernceMethod
        }// end of class
}// end namespace
