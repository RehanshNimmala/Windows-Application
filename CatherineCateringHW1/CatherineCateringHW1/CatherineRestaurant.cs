using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatherineCateringHW1
{
    public partial class CatherineRestaurant : Form
    {
        public CatherineRestaurant()
        {
            InitializeComponent();
        }
        //Declaring the variables at the global level
        int guest = 0;
        double amountDue = 0;
        double totalAmount = 0;
        const double tax_Rate = 0.012;

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int guests;

            CalculateBilling calculateBilling = new CalculateBilling();
           

            if(int.TryParse(numberofGuestsTextBox.Text, out guests))
            {
                if(guests <= 15)
                {
                    if(primeribRadioButton.Checked)
                    {
                        amountDue = calculateBilling.resultPrimeRib(guests);
                        double tip = amountDue * 0.2;
                        double tax = amountDue * tax_Rate;
                        double totalAmount = amountDue + tip + tax;
                        preTaxTip.Text = tip.ToString("N2");
                        amountDueLabel.Text = "$"+totalAmount.ToString("N2");

                    }
                    else if(chickenRadioButton.Checked)
                    {
                        amountDue = calculateBilling.resultChicken(guests);
                        double tip = amountDue * 0.2;
                        double tax = amountDue * tax_Rate;
                        double totalAmount = amountDue + tip + tax;
                        preTaxTip.Text = tip.ToString("N2");
                        amountDueLabel.Text = "$" + totalAmount.ToString("N2");
                    }
                    else if(pastaRadioButton.Checked)
                    {
                        amountDue = calculateBilling.resultPasta(guests);
                        double tip = amountDue * 0.2;
                        double tax = amountDue * tax_Rate;
                        double totalAmount = amountDue + tip + tax;
                        preTaxTip.Text = tip.ToString("N2");
                        amountDueLabel.Text = "$" + totalAmount.ToString("N2");
                    }
                    totalGuestsLabel.Text = guest +guests.ToString();
                    totalAmountDue.Text = amountDue + totalAmount.ToString();
                }
            }


        }

       
    }
}
