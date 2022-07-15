//Programmer Name: Naveen Nimmala
//Project: Exam 1
//Description: Receipt generation for Boat rentals

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimmalaExam1
{
    public partial class BoatRentalForm : Form
    {
        public BoatRentalForm()
        {
            InitializeComponent();
        }
        // Field Scope of variable
        int count = 0;
        private void btnDisplayRentalReceipt_Click(object sender, EventArgs e)
        {
            //Exception handling
            try
            {
                // Declaring variables

                string customerDrivingLicense;
                string boatName;
                string rentalcode;
                DateTime rentStartDate;
                double numberOfDays;
                double subTotal;
                const double RENT_DAY = 75;

                //Input

                customerDrivingLicense = txtCustomerDrivingLicense.Text;
                boatName = txtBoatName.Text;
                rentStartDate = dtpRentStartDate.Value;

                //Processing

                TimeSpan days = DateTime.Today - rentStartDate;
                numberOfDays = days.Days;
                rentalcode = customerDrivingLicense + "_" + boatName.Substring(0, 2).ToUpper();
                subTotal = numberOfDays * RENT_DAY;
                count = count + 1;


                //Output
                lstReceipt.Items.Add("Adventure Boat Rentals");
                lstReceipt.Items.Add("");
                lstReceipt.Items.Add("Receipt");
                lstReceipt.Items.Add("");
                lstReceipt.Items.Add(string.Format("{0,12}{1,10}", "Rental Code:", rentalcode));
                lstReceipt.Items.Add(string.Format("{0,12}{1,10}", "Days Rented:", numberOfDays));
                lstReceipt.Items.Add(string.Format("{0,12}{1,10:C}", "SubTotal:", subTotal));
                lstReceipt.Items.Add("");
                lstReceipt.Items.Add(string.Format("{0,12}{1,8}", "Customer Count:", count));

                lstReceipt.Items.Add("");
                lstReceipt.Items.Add("Thank You");
            }
            catch 
            {
                MessageBox.Show("An Error Occured During the Process", "Error");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Resets the Transaction

            txtCustomerDrivingLicense.Clear();
            txtBoatName.Clear();
            lstReceipt.Items.Clear();
            dtpRentStartDate.Value = DateTime.Today;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit the Application

            this.Close();
        }
    }
}
