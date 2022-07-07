//Programmer Name: Naveen Nimmala
//Project Number: Assignment 1
// Description:Department contact details of a company


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimmalaAssign1
{
    public partial class CompanyContactDetails : Form
    {
        public CompanyContactDetails()
        {
            InitializeComponent();
        }

        private void CompanyContactDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            //Details of Marketing department
            lblDisplay.Text = "(660) 422-4788";
        }

        private void btnOrderProcessing_Click(object sender, EventArgs e)
        {
            //Details of Order Processing department
            lblDisplay.Text = "(660) 422-9618";
        }

        private void btnShipping_Click(object sender, EventArgs e)
        {
            //Details of Shipping department
            lblDisplay.Text = "(660) 422-6247";
        }

        private void btnCustomerRelations_Click(object sender, EventArgs e)
        {
            //Details of Customer Relations department
            lblDisplay.Text = "(660) 422-4243";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Resets the information
            lblDisplay.Text = "";
        }
    }
}
