//Programmer Name: Naveen Nimmala
//Project Name: Assignment 4
//Description: Hotel Reservation Form


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimmalaAssign4
{
    public partial class HotelReservationForm : Form
    {
        public HotelReservationForm()
        {
            InitializeComponent();
        }

        private void btnDisplayReceipt_Click(object sender, EventArgs e)
        {
            // Declaring the variables and Constants

            string customerName;
            string status;
            const double DISCOUNT_1= 0.2;
            const double DISCOUNT_2 = 0.3;
            const double DISCOUNT_3 = 0.4;
            const double RATE_DAY = 144.99;
            double totalDiscount=0;
            double subTotal = 0;
            double amountDue = 0;
            double numberOfDays;
            
            customerName = txtCustomerName.Text;
            status = txtStatus.Text;

            
            if (txtCustomerName.Text.Length > 0 && txtNumberOfDays.Text.Length > 0)
            {
                numberOfDays = double.Parse(txtNumberOfDays.Text);

                if (numberOfDays > 0)
                {
                    subTotal = numberOfDays * RATE_DAY;

                    if (numberOfDays >= 2 && numberOfDays <= 4)
                    {
                        if (txtStatus.Text.ToUpper() == "GOLD")
                        {
                            totalDiscount = subTotal * DISCOUNT_1;
                        }
                        else if (txtStatus.Text.ToUpper() == "PLATINUM")
                        {
                            totalDiscount = subTotal * DISCOUNT_2;
                        }
                        else
                        {
                            totalDiscount = 0;
                        }
                    }

                    else if (numberOfDays >= 5)
                    {
                        if (txtStatus.Text.ToUpper() == "GOLD")
                        {
                            totalDiscount = subTotal * DISCOUNT_2;
                        }
                        else if (txtStatus.Text.ToUpper() == "PLATINUM")
                        {
                            totalDiscount = subTotal * DISCOUNT_3;
                        }
                        else
                        {
                            totalDiscount = 0;
                        }
                    }

                    else
                    {
                        totalDiscount = 0;
                    }

                    // Processing
                    amountDue = subTotal - totalDiscount;


                    //Output
                    lstReservation.Items.Add("Confirmation of Reservation");
                    lstReservation.Items.Add("");

                    lstReservation.Items.Add(string.Format("{0,08}{1,10}", "Customer Name:", customerName));
                    lstReservation.Items.Add(string.Format("{0,08}{1,10}", "Number Of Days:", numberOfDays));
                    lstReservation.Items.Add(string.Format("{0,08}{1,10:C}", "Total Charge:", subTotal));
                    lstReservation.Items.Add(string.Format("{0,08}{1,10:C}", "Discount Amount:", totalDiscount));
                    lstReservation.Items.Add(string.Format("{0,08}{1,10:C}", "Amount Due:", amountDue));
                }
                else
                {
                    MessageBox.Show("Please enter a valid Input");
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid Input");

            }

        }

        private void txtNumberOfDays_Validating(object sender, CancelEventArgs e)
        {
            // Verifying the correct input
            double numberOfDays;
        
            if (double.TryParse(txtNumberOfDays.Text,out numberOfDays) ==false)
            {
                erpReservations.SetError(txtNumberOfDays, "Enter valid number of days");
                txtNumberOfDays.Focus();
                txtNumberOfDays.SelectAll();
                return;
            }
           else
            {
                erpReservations.SetError(txtNumberOfDays, "");
            }
           
        }

        private void txtCustomerName_Validating(object sender, CancelEventArgs e)
        {
            // Verifying the Correct input
            if (txtCustomerName.Text.Length > 0)
            {
                erpReservations.SetError(txtCustomerName, "");

            }
            else
            {
                erpReservations.SetError(txtCustomerName, "Enter valid Customer Name");
                txtCustomerName.Focus();
                txtCustomerName.SelectAll();
                return;
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears the Transaction
            txtCustomerName.Clear();
            txtNumberOfDays.Clear();
            txtStatus.Clear();
            lstReservation.Items.Clear();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the Transaction
            this.Close();
        }
    }
}
