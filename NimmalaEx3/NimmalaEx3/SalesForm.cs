//Programmer Name: Naveen Nimmala
//Project Number: Exercise 3
//Description: Transaction Form

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimmalaEx3
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }


        private void btnProcessSale_Click(object sender, EventArgs e)
        {
            //Process the Transaction

         
            int quantity;
            double price;
            double amountDue;

            
            quantity = int.Parse(txtQuantity.Text);
            price = double.Parse(txtPrice.Text);
            amountDue = quantity * price;


            lblAmountDue.Text = amountDue.ToString("C");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Resets the Transaction
            txtQuantity.Clear();
            txtPrice.Clear();
            lblAmountDue.Text = "";


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the Transaction
            this.Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
