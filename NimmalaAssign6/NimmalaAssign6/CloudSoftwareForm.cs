// Programmer Name: Naveen Nimmala
//Project Name: Assignment 6
//Description: Application using methods and controlls



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimmalaAssign6
{
    public partial class CloudSoftwareForm : Form
    {
        public CloudSoftwareForm()
        {
            InitializeComponent();
        }
        // Declaring the Constants
        const double SALES_MANAGEMENT = 300;
        const double CLOUD_PROJECT = 100;
        const double PAYROLL_SOLUTIONS = 500;
        const double EASY_MEETING = 60;
        const double CLOUD_CHARGES = 2.5;
        const double NPO_DISCOUNT = 0.2;

       

        private void btnDisplayInvoice_Click_1(object sender, EventArgs e)
        {

            try
            {
                //Declaring the variables
                int numberOfUsers;
                double storageAmount;
                double softwareCharge = 0;
                double discount = 0;


                if (txtClientName.Text.Length > 0)// makes sure a name is entered
                {
                    if (int.TryParse(txtNumberOfUsers.Text, out numberOfUsers))// validates number of users
                    {
                        if (cboApplicationType.SelectedIndex == 0 || cboApplicationType.SelectedIndex == 1 ||
                   cboApplicationType.SelectedIndex == 2 || cboApplicationType.SelectedIndex == 3)// validates the combobox
                        {
                            if (rdbStoredCloud.Checked == true || rdbStoredOnpremise.Checked == true)// validates the radio buttons
                            {
                                if (double.TryParse(txtStorageUsed.Text, out storageAmount)) // validates Storage amount
                                {


                                    softwareCharge = GetRatePerUSer();
                                    storageAmount = double.Parse(txtStorageUsed.Text);
                                    double storageCharges = CalculatingStorageCharge(storageAmount);

                                    DisplayInvoice(txtClientName.Text, softwareCharge, storageCharges, discount);
                                }
                                else
                                {
                                    MessageBox.Show("Enter Amount of Storage", "Invalid input");
                                }
                            
                            }
                            else
                            {
                                MessageBox.Show("Select Data storage Location", "Invalid input");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Select Desired Application", "Invalid input");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Enter Number of users", "Invalid input");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Client name", "Invalid input");
                }
            }
            catch
            {
                MessageBox.Show("An unexpected error has occured. Try again");
            }
        }
        private double GetRatePerUSer() //method 1 without parameters
        {
            
            double rate = 0;
            double softwareCharge;
            int numderOfUsers = int.Parse(txtNumberOfUsers.Text);
            if (cboApplicationType.SelectedIndex == 0)
            {
                rate = SALES_MANAGEMENT;
            }
            if (cboApplicationType.SelectedIndex == 1)
            {
                rate = CLOUD_PROJECT;
            }
            if (cboApplicationType.SelectedIndex == 2)
            {
                rate = PAYROLL_SOLUTIONS;
            }
            if (cboApplicationType.SelectedIndex == 3)
            {
                rate = EASY_MEETING;
            }
            softwareCharge = rate * numderOfUsers;
            return softwareCharge;
        }

        private double CalculatingStorageCharge(double storageAmount)// method 2 
        {
            double storageCharges = 0;
            if (rdbStoredCloud.Checked == true)
            {
                storageCharges = storageAmount * CLOUD_CHARGES;
            }
            if (rdbStoredOnpremise.Checked == true)
            {
                storageCharges = 0;
            }
            return storageCharges;
        }
        private void DisplayInvoice(string clientName, double softwareCharge, double storageUsageCharge, double discount)// method 3

        {
            double totalAmount = softwareCharge + storageUsageCharge;
            double discountAmount = 0;
            double amountDue;
            if (chkNonForProfit.Checked == true)
            {
                discountAmount = totalAmount * NPO_DISCOUNT;
            }
            else
            {
                discountAmount = 0;
            }
            amountDue = totalAmount - discountAmount;

            lstDisplay.Items.Add("Client Name:" + "" + clientName);
            lstDisplay.Items.Add("Software Charge:" + "" + softwareCharge.ToString("C"));
            lstDisplay.Items.Add("Storage Usage Charge:" + "" + storageUsageCharge.ToString("C"));
            lstDisplay.Items.Add("Discount Amount:" + "" + discountAmount.ToString("C"));
            lstDisplay.Items.Add("Amount Due:" + "" + amountDue.ToString("C"));



        }

        private void btnClear_Click(object sender, EventArgs e)// clears the transaction using method
        {
            ResetControls();
        }

        
            private void ResetControls()
            {
               
                txtClientName.Clear();
                txtClientName.Focus();
                txtNumberOfUsers.Clear();
                txtStorageUsed.Clear();
                lstDisplay.Items.Clear();

            }

        private void btnExit_Click(object sender, EventArgs e)// Exits the transaction
        {
            this.Close();
        }

        

    }


}
