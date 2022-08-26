//Created by Nimmala

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimmalaWeek2
{
    public partial class tempConverterForm : Form
    {
        public tempConverterForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit the Form
            this.Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
          //Declaring the variables

          decimal tempEntered;
            decimal celcius;
            decimal farenhiet;
            string result;

            //validation for temperature text box
            if (decimal.TryParse(temperatureTextBox.Text, out tempEntered))
            {
                //Instantiate the class
                TempConverter tempConverter = new TempConverter();

                //Validation for radio buttons
                if (farenhietRadioButton.Checked == true) //user entered farenhiet, So Fto C method shall be called from TempConverter class
                {
                    celcius = tempConverter.FtoC(tempEntered);
                    result = tempEntered.ToString("N3") + "degree Farenheits=" + celcius.ToString("N3") + " degree Celcius";
                    resultLabel.Text = result;// Displaying the result in label
                }
                else if (celciusRadioButton.Checked == true)// User entered celcius, So CtoF method to be called from class TempConverter
                {
                    farenhiet = tempConverter.CtoF(tempEntered);
                    result = tempEntered.ToString("N3") + "degree celcius=" + farenhiet.ToString("N3") + " degree Farenheits";

                    resultLabel.Text = result;// Displaying the result in label
                }
                else
                {
                    //If radio button not checked
                    resultLabel.Text = "Please select the celcius or Farenhiet";
                }// End of radio button sction
            }
            else
            {
                // Invalid input in textbox
                resultLabel.Text = "Please enter a valid numerical temperature value";
                temperatureTextBox.SelectAll();
                temperatureTextBox.Focus();
            }// end of validation


        }// End of button convert 

        private void button1_Click(object sender, EventArgs e)
        {
            temperatureTextBox.Text = "";
            resultLabel.Text = "";
            farenhietRadioButton.Checked = false;
            celciusRadioButton.Checked = false;

        }
    }//End of class
}//End of Namespace
