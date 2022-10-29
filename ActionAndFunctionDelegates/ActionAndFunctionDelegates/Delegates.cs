using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActionAndFunctionDelegates
{
    public partial class Delegates : Form
    {
        public Delegates()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void functionDelegateButton_Click(object sender, EventArgs e)
        {
            /*Declaring function delegate instance (the object is Func<T,T>) which receives one incoming pqrameter, and returns one value of type T
             * Function delegates always returns a value. They may have 0 or more parameters.*/

            Func<String, String> toUCFunctionDelegate = s => s.ToUpper() +"  "+ "Function Delegate";

            //using the function delegate above:
            string inputString=stringTextBox.Text;
            resultLabel.Text=toUCFunctionDelegate(inputString);
        }//Function Delegate Button

        private void actionDelegateWithLambdaButton_Click(object sender, EventArgs e)
        {
            /* Action Delgate Instntiation Action<T> is the object being instantiated.
             * Action delegates do not return values
             * Action delegates may take 0 or more parameters*/

            Action<string> stringReverseActionDelegate = myString =>
            {
                char[] myArray = myString.ToCharArray();//convert string to character array
                Array.Reverse(myArray);//reversing the order of elements
                resultLabel.Text = new string(myArray).ToUpper() +"  "+"Action Delegate";
            };
            //Get input from the text box
            string inputString = stringTextBox.Text;
            //Using the action delegate instantiated above:
            stringReverseActionDelegate(inputString);
        }//ActDel Button

        private void multicastDelegateButton_Click(object sender, EventArgs e)
        {
            /*A useful property of delegate is that multiple objects can be assigned to one delegate instance by using the + oerator
             * The multicast delegate contains a list of the assigned delegates
             * When the multicast delegte is called, it invokes the delegates in the list, in order.
             * Only delegates of the same type can be combined.*/

            //declare and instantiate two instances of action delegates
            //Observe both delegate instances below have the same method signatures: take one incoming parameter of the type string.
            //#1
            Action<string> toUpperCaseActionDelegate = myString =>
            {
               //converts the string supplied to upper case and displays in the result label.
                resultLabel.Text = myString.ToUpper() + Environment.NewLine;
            };

            //2
            Action<string> stringReverseActionDelegate = myString =>
            {
                char[] myArray = myString.ToCharArray();//convert string to character array
                Array.Reverse(myArray);//reversing order of elements
                resultLabel.Text += new string(myArray).ToUpper();
            };// ActionDelegate declaration 2

            //using the delegates instantiated above in a single multicast deelegate.
            //First get the input entered in the text box:
            string inputString= stringTextBox.Text;

            //declarig a multicast delegate bu combining the two delegates above
            var multiDelegate = toUpperCaseActionDelegate + stringReverseActionDelegate;
            
            // use the multicast delegate

            multiDelegate(inputString);

        }//MulticastDelegate button

        private void stringTextBox_Enter(object sender, EventArgs e)
        {
            if(stringTextBox.Text == "Enter a text here")
            {
                stringTextBox.Text = "";
            }
        }

        private void stringTextBox_Leave(object sender, EventArgs e)
        {
            if(stringTextBox.Text=="")
            {
                stringTextBox.Text = "Enter a text here";
            }
        }
    }//form
}//Namespace
