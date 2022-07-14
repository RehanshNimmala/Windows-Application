//Programmer Name: Naveen Nimmala
//Project Name : Exercise 4
//Description : Car Rentals Transaction

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimmalaEX4
{
    public partial class RentalBusiness : Form
    {
        public RentalBusiness()
        {
            InitializeComponent();
        }
        // Scope (field) of variable
        double totalRevenue = 0;
        
        //Clear the Transaction
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInitialReading.Clear();
            txtFinalReading.Clear();
            txtDays.Clear();
            lstReceipt.Items.Clear();
           
        }

        //Processing the Transaction
        private void btnGenerateRentalReceipt_Click(object sender, EventArgs e)
        {
            //Declaring the variables
            double initialReading;
            double finalReading;
            double days;
            double milesDriven;
            double numberOfDays;
            double totalCharge;
            //constants
            const int DAILY_CHARGE = 20;
            const double MILE_CHARGE = 0.15;
            //Get input
            initialReading = double.Parse (txtInitialReading.Text);
            finalReading = double.Parse(txtFinalReading.Text);
            days = double.Parse(txtDays.Text);
            //processing
            milesDriven = finalReading - initialReading;
            numberOfDays  = days;
            totalCharge=(MILE_CHARGE*milesDriven)+(DAILY_CHARGE * numberOfDays);
            totalRevenue = totalRevenue + totalCharge;

            //output
            lstReceipt.Items.Add(string.Format("{0,25}", "RELIABLE RENTALS"));
            lstReceipt.Items.Add("");


            lstReceipt.Items.Add(string.Format("{0,12}", "Customer Receipt"));
            lstReceipt.Items.Add("---------------------------------");

            lstReceipt.Items.Add(string.Format("{0,12}{1,10}", "Miles Driven:", milesDriven));
            lstReceipt.Items.Add(string.Format("{0,12}{1,8}", "Number of Days:", numberOfDays));
            lstReceipt.Items.Add(string.Format("{0,12}{1,10:C}", "Total Charge:", totalCharge));
            lstReceipt.Items.Add("");
            lstReceipt.Items.Add(string.Format("{0,20}", "Thank You!"));


            //Summary
            lstReceipt.Items.Add("---------------------------------");
            lstReceipt.Items.Add(string.Format("{0,15}", "Summary"));
            lstReceipt.Items.Add("");

            lstReceipt.Items.Add(string.Format("{0,12}{1,10:C}", "Total Revenue:", totalRevenue));

        }

        //Exit the Transaction
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
