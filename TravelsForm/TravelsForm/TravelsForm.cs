using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelsForm
{
    enum TravelClass
    {
        NoSelection=0,
        Economy=1,
        FirstClass=2
    }
    public partial class TravelsForm : Form
    {
        int travelClass;
        public TravelsForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getFareButton_Click(object sender, EventArgs e)
        {
            int numberOfTravelers;
            string destination;
            decimal amountdue;

            errorProvider1.Clear();
            if(destinationComboBox.SelectedIndex != - 1)
            {
                destination = destinationComboBox.SelectedItem.ToString();
                if(travelClass > 0)
                {
                    try
                    {
                        numberOfTravelers=int.Parse(travelersTextBox.Text);
                        if(numberOfTravelers > 0 && numberOfTravelers < 10)
                        {
                            switch (destinationComboBox.SelectedItem.ToString())
                            {
                                case "Carribbean Cruise":
                                    //MessageBox.Show("Carebian is passed");
                                    BillingClass carribbeanInstance=new BillingClass(numberOfTravelers);
                                    amountdue = carribbeanInstance.CalculateDue(travelClass);
                                    fareLabel.Text = $"Total fare for {numberOfTravelers} travelers, by {(TravelClass)travelClass} is {amountdue.ToString("C")}";
                                    break;
                                case "Alaskan Cruise":
                                    //MessageBox.Show("Alaskan is passed");
                                    AlaskanClass alaskanInstance=new AlaskanClass(numberOfTravelers);
                                    amountdue=alaskanInstance.CalculateDue();
                                    fareLabel.Text = $"Total fare for {numberOfTravelers} travelers, by {(TravelClass)travelClass} is {amountdue.ToString("C")}";
                                    break;
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(travelersTextBox, "Number of travelers must be between 1 and 9");

                        }
                    }catch(Exception ex)
                    {
                        errorProvider1.SetError(travelersTextBox, ex.Message + "Enter number of travelers as an integer");

                    }
                }
                else
                {
                    errorProvider1.SetError(classGroupBox, "Select Class");
                }
            }
            else
            {
                errorProvider1.SetError(destinationComboBox, "Select Destination");
            }
        }

        private void FirstClassRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton selectedRadio=(RadioButton)sender;
            string rad = classGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name; ;
            classGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r=>r.Checked).Name = rad;
            //MessageBox.Show("Selected radio button is:" + rad);
            switch (rad)
            {
                case "firstClassRadioButton":
                    travelClass = (int)TravelClass.FirstClass;
                    //MessageBox.Show("firstClassRadioButton selected\ntravel Class int Value is:" + travelClass);
                    break;
                case "economyRadioButton":
                    travelClass = (int)TravelClass.Economy;
                    //MessageBox.Show("economyRadioButton selected\ntravel Class int Value is:" + travelClass);
                    break;
            }
            
        }

        private void DestinationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(destinationComboBox.SelectedIndex == 1)
            {
                economyRadioButton.Checked = true;
                travelClass = (int)TravelClass.Economy;
                firstClassRadioButton.Enabled=false;
            }
            else
            {
                firstClassRadioButton.Enabled = true;
                firstClassRadioButton.Checked = true;
                travelClass = (int)TravelClass.FirstClass;
                economyRadioButton.Checked = false;
                //travelClass = 0;
            }
            //MessageBox.Show("travel Class int Value is:" + (int)TravelClass.FirstClass);
        }

        
    }
}
