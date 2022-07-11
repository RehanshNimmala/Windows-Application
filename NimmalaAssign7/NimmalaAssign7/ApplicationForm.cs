//Programmer Name: Naveen Nimmala
//Project Name: Assignment 7
//Description: Applicatin using Arrays

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NimmalaAssign7
{
    public partial class ApplicationForm : Form
    {

        public ApplicationForm()
        {
            InitializeComponent();
        }
        private void ApplicationForm_Load(object sender, EventArgs e)//Reading data from the file(Task 1)
        {
            try
            {
                StreamReader flooringTypeReader = new StreamReader("FlooringTypes.txt");
                while (flooringTypeReader.EndOfStream == false)
                {
                    cboFlooringType.Items.Add(flooringTypeReader.ReadLine());
                }
                flooringTypeReader.Close();
            }
            catch
            {
                MessageBox.Show("Please select the Type of flooring");
            }
        }

        private void btnGenerateEstimate_Click(object sender, EventArgs e)//Generating the estimate(Task 2)
        {
            string customerName, type;
            double requiredQuantity;
            double totalCharge = 0;
            const double CARPET = 3.5;
            const double HARDWOOD = 4.5;
            const double VINYL = 2.75;
            const double TILE = 5.75;
            double rate = 0;
            if (txtCustomerName.Text.Length == 0)
            {
                MessageBox.Show("Enter customer name");
                txtCustomerName.Focus();
                txtCustomerName.SelectAll();
            }
            else
            {
                if (cboFlooringType.SelectedIndex == 0 || cboFlooringType.SelectedIndex == 1 || cboFlooringType.SelectedIndex == 2 ||
                    cboFlooringType.SelectedIndex == 3)
                {

                    if (double.TryParse(txtQuantityRequired.Text, out requiredQuantity) == false)
                    {
                        MessageBox.Show("Enter the required Quantity!");
                        txtQuantityRequired.Focus();
                        txtQuantityRequired.SelectAll();
                    }
                    else
                    {
                        customerName = txtCustomerName.Text.ToUpper();
                        type = cboFlooringType.SelectedItem.ToString();
                        if (cboFlooringType.SelectedIndex == 0)
                        {
                            rate = CARPET;

                        }
                        if (cboFlooringType.SelectedIndex == 1)
                        {
                            rate = HARDWOOD;
                        }
                        if (cboFlooringType.SelectedIndex == 2)
                        {
                            rate = VINYL;
                        }
                        if (cboFlooringType.SelectedIndex == 3)
                        {
                            rate = TILE;
                        }

                        //Calculate rental charge
                        totalCharge = rate * requiredQuantity;

                        //Display confirmation

                        lstOutput.Items.Add("Estimation Report");
                        lstOutput.Items.Add("Customer Name: " + customerName);
                        lstOutput.Items.Add(" Flooring Type: " + type);
                        lstOutput.Items.Add(" Number of Sq.ft: " + requiredQuantity);

                        lstOutput.Items.Add(" Total Amount: " + totalCharge.ToString("C"));


                        //writing the data to PotentialCustomers.txt file

                        StreamWriter potentialCustomerWriter = new StreamWriter("PotentialCustomers.txt",true);
                        potentialCustomerWriter.WriteLine(customerName);
                        potentialCustomerWriter.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select the Type of flooring");
                }
            }
        }

        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            int count = 0;
            StreamReader potentialCustomerReader = new StreamReader("PotentialCustomers.txt");
            while (potentialCustomerReader.EndOfStream == false)
            {
                potentialCustomerReader.ReadLine();
               count++;
            }
            potentialCustomerReader.Close();

            // Declare an array to store the names of Customers
            string[] customerNames = new string[count];

           
            int i = 0; // // Reading the data from the array
            potentialCustomerReader = new StreamReader("PotentialCustomers.txt");
            while (potentialCustomerReader.EndOfStream == false)
            {
                customerNames[i] = potentialCustomerReader.ReadLine();
                i++;
            }
            potentialCustomerReader.Close();

            lstOutput.Items.Add("Customer Names");

            foreach (string name in customerNames)
            {
                lstOutput.Items.Add(name);// Displaying the names of the customers
            }

            lstOutput.Items.Add(" Total number of Customers:" + count);// Displaying the count
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)// Searching the Customer Name
        {
            if(txtCustomerName.Text.Length>0)
            {
                string customerName = txtCustomerName.Text.ToUpper();
               
                StreamReader potentialCustomerReader = new StreamReader("PotentialCustomers.txt");
                while (potentialCustomerReader.EndOfStream == false)
                {
                    if (potentialCustomerReader.ReadLine() == customerName)
                    {
                        lstOutput.Items.Add("The Customer already Exists");

                    }
                    else
                    {
                        lstOutput.Items.Add("The Customer do not Exists") ;

                    }
                }
                      potentialCustomerReader.Close();

            }
            else
            {
                MessageBox.Show("Please enter the customer Name");
            }
         }   


        private void btnClear_Click(object sender, EventArgs e) // Clears the transaction
        {
            txtCustomerName.Text = "";
            txtQuantityRequired.Text = "";
            lstOutput.Items.Clear();
            
        }

        private void btnExit_Click(object sender, EventArgs e) //Exits the transaction
        {
            this.Close();
        }
    }
}
