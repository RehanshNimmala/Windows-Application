using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyTax
{
    //Created by Nimmala
    //22222222222222222
    public partial class PropertyTax : Form
    {
        public PropertyTax()
        {
            InitializeComponent();
        }

      

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal valueEntered;
            decimal taxDecimal;

            try
            {
                valueEntered = decimal.Parse(valueTextBox.Text);

                //Instantiate the class TaxClass
                TaxClass propTaxInstance = new TaxClass();

                taxDecimal = propTaxInstance.CalculateTax(valueEntered);
                taxLabel.Text = "$"+taxDecimal.ToString();
            }
            catch (FormatException )
            {

                MessageBox.Show("Invalid Value.Please enter decimal as a decimal", "Invalid Input", MessageBoxButtons.OK);
                valueTextBox.SelectAll();
                valueTextBox.Focus();
            }
            catch(Exception)
            {
                MessageBox.Show("Error", "Invalid Input");
                valueTextBox.SelectAll();
                valueTextBox.Focus();

            }// End of second catch

        }// End of Calculate button 

        private void taxTableButton_Click(object sender, EventArgs e)
        {
            // This displays property taxes in increments of $25000 from 100000 through 800000.

            decimal taxDue;
            //Instantiate the Tax class

            TaxClass taxClass = new TaxClass();
            for(int propValue=100000;propValue<=800000;propValue+=25000)
            {
                taxDue = taxClass.CalculateTax(propValue);
                taxListBox.Items.Add(propValue.ToString("C")+":"+ taxDue.ToString("C"));
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
