//Programmer Name: Naveen Nimmala
// Project Name: Assignment 5
//Description: To calculate the Depreciation values using Straight-line method and Declining balance method

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimmalaAssign5
{
    public partial class DepreciationForm : Form
    {
        public DepreciationForm()
        {
            InitializeComponent();
        }

        //Straight line Method
        private void btnCalculateDepreciation_Click(object sender, EventArgs e)
        {
            //Declaring the Variables
            string description = txtDescription.Text;
            int yearOfPurchase ;
            double purchasePrice;
            int numberOfyears ;
            double depreciationPrice;

            double totalDepreciation;
            int year=0 ;


            // Input Validation
            if (txtDescription.Text.Length > 0)
            {
                if (int.TryParse(txtYearOfPurchase.Text, out yearOfPurchase))
                {
                    if (double.TryParse(txtPurchasePrice.Text, out purchasePrice))
                    {
                        if (int.TryParse(txtNumberOfYears.Text, out numberOfyears))
                        {
                            //Processing

                            depreciationPrice = purchasePrice / numberOfyears;
                            totalDepreciation = 0;

                            lstStraightLineDisplay.Items.Add("Year" + "       " + "Residual Value" + "    " + "Depreciation");
                            while (year < numberOfyears)
                            {
                                double residualValve = purchasePrice - depreciationPrice;
                                totalDepreciation += depreciationPrice;
                                yearOfPurchase++;
                                year++;
                                purchasePrice=residualValve ;
                                //Output

                                lstStraightLineDisplay.Items.Add(yearOfPurchase + "          " +residualValve.ToString("C")+"                   "+ totalDepreciation.ToString("C"));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid Number of Year Values");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter valid  Purchase Price Values");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid Year of Purchase Values");
                }
            }
            else
            {
                MessageBox.Show("Please enter input Values");
            }



        }
        //Decline balance method
        private void btnCalculateDepreciationDecliningBalance_Click(object sender, EventArgs e)
        {
            //Declaring the Variables
          string description = txtDescriptionDecliningBalance.Text;
            int yearOfPurchase;
            double purchasePrice;
            double depreciationRate;
            double rate;
            double totalDepreciation = 0;
            double depreciationPrice;



            if (txtDescriptionDecliningBalance.Text.Length>0)             //Input Validation

            {
                if (int.TryParse(txtYearOfPurchaseDecliningBalance.Text, out yearOfPurchase))
                {
                    if (double.TryParse(txtPurchasePriceDecliningBalance.Text, out purchasePrice))
                    {
                        if (double.TryParse(txtDepreciationRate.Text, out depreciationRate))
                        {
                            //Processing

                            lstDecliningBalanceDisplay.Items.Add("Year " + "        " + " Value" + "     " + " Depreciation");

                            rate = depreciationRate / 100;
                            while (purchasePrice > 0.005)
                            {
                                depreciationPrice = purchasePrice * rate;
                                purchasePrice = purchasePrice - depreciationPrice;
                                totalDepreciation += depreciationPrice;
                                yearOfPurchase++;

                                //Output
                                lstDecliningBalanceDisplay.Items.Add(yearOfPurchase + "        " + purchasePrice.ToString("C") + "          " + totalDepreciation.ToString("C"));

                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid Depreciation Values");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid  Purchase Price Values");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid Year of Purchase Values");
                }

            }

            else 
            {
                MessageBox.Show("Please enter input Values");
            }
        }

        //Resets the Declining balance method
        private void btnResetDecliningBalance_Click(object sender, EventArgs e)
        {
            txtDepreciationRate.Text = "";
            txtDescriptionDecliningBalance.Text = "";
            txtPurchasePriceDecliningBalance.Text = "";
            txtYearOfPurchaseDecliningBalance.Text = "";
            lstDecliningBalanceDisplay.Items.Clear();
               
        }

        // Resets the Straight line method
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            txtNumberOfYears.Text = "";
            txtPurchasePrice.Text = "";
            txtYearOfPurchase.Text = "";
            lstStraightLineDisplay.Items.Clear();
        }

        //Exits the Application
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
