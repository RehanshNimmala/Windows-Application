using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimmalaWeek6
{
    //Created by Nimmala
    //222222222222222222222
    public partial class GenericsClass : Form
    {
        public GenericsClass()
        {
            InitializeComponent();
        }

        private void integerButton_Click(object sender, EventArgs e)
        {
            // Integer Array
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };//Integer Array
            
            //Instantiate Generic class
            MyGenericClass <int> myIntClass=new MyGenericClass<int>(intArray);
            outputLabel.Text = "";
            foreach ( int intElement in myIntClass.GenericArray)
            {
                // call the generic method to display the result
                LabelWriter<int>(intElement);
            }//End foreach

        }// Integer button

        private void doubleButton_Click(object sender, EventArgs e)
        {
            //double Array
            double[] doubleArray = { 1.11, 2.22, 3.33, 4.44, 5.55, 6.66, 7.77, 8.88, 9.99 };
            // Instantiate the generic class
            MyGenericClass<double> myDoubleClass=new MyGenericClass<double>(doubleArray);
            //Reset label text:
            outputLabel.Text = "";
            foreach (double  doubleElement in  myDoubleClass.GenericArray)
            {
                //call the generic method to display the result
                LabelWriter<double>(doubleElement);
            }
        }//double button

        private void stringButton_Click(object sender, EventArgs e)
        {
            //String Array
            string[] stringArray = { "G", "E", "N", "E", "R", "I", "C", "S" };
            //Instantiate the generic class
            MyGenericClass<string> myStringClass=new MyGenericClass<string>(stringArray);

            //reset label:
            outputLabel.Text = "";
            foreach (string stringElement in myStringClass.GenericArray)
            {
                // call the generic method to display the result
                LabelWriter<string>(stringElement);

            }// End foreach
        }//end stringbutton

        private void charButton_Click(object sender, EventArgs e)
        {
            //Char array
            char[] charArray = { 'C', 'H', 'A', 'R', 'T', 'Y', 'P', 'E' };
            // INSTANTIATE THE CLASS 
            MyGenericClass<char> myCharClass=new MyGenericClass<char>(charArray);
            //RESET LABEL:
            outputLabel.Text = "";
            foreach(char CharElement in myCharClass.GenericArray)
            {
                //call the generic method to display result
                LabelWriter<char>(CharElement);
            }// Enf Foreach
        }// end char button

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }// Exit button

        private void LabelWriter<T>(T element)// Generic Method
        {
            outputLabel.Text += $@"Output from Generic Class's GenericArray Property{element.ToString()}.
                    Data Type is:{element.GetType().Name}{Environment.NewLine}";

        }// LabelWriter<T>()
    }//form
}//namespace
