
//Programmer Name: Naveen Nimmala
//Project Name: Game Rentals
//Description:Generate the receipt based on first name, last name and type of the game.//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimmalaAssign3
{ 
    
    public partial class GamesRentalForm : Form
    {
        
        public GamesRentalForm()
        {
            InitializeComponent();
        }

        private void GamesRentalForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrintReturnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaring the variables

                string firstName;
                string lastName;
                string title;
                string platform;
                string game;
                double totalCharge;
                DateTime rentDate;
                int totalDays;
                string customerName;
                const double DAY_CHARGE = 2.5;
                DateTime currentDate;

                // Input

                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;
                title = txtTitle.Text;
                platform = txtPlatform.Text;
                rentDate = dtpRentDate.Value;
                currentDate = DateTime.Now;

                //processing
                TimeSpan daysRented = (DateTime.Today - rentDate);
                totalDays = daysRented.Days;
                totalCharge = totalDays * DAY_CHARGE;
                customerName = firstName + " " + lastName.Substring(0, 1)+".";
                game = title.Substring(0, 5) + platform.Substring(0, 2).ToUpper();


                //Output
                lstReceipt.Items.Add(string.Format("{0, 35}", "Customer Receipt"));
                lstReceipt.Items.Add("------------------------------------------------------");
                lstReceipt.Items.Add(string.Format("{0, 10}", "Game Hub"));
                lstReceipt.Items.Add(string.Format("{0, 10}", "ABC Street"));
                lstReceipt.Items.Add(string.Format("{0, 10}", "Kansas City"));
                lstReceipt.Items.Add("------------------------------------------------------");

                lstReceipt.Items.Add(string.Format("{0,08}{1,10}", "Receipt Date:", currentDate));
                lstReceipt.Items.Add("");

                lstReceipt.Items.Add(string.Format("{0,08}{1,10}", "Customer Name:", customerName));
                lstReceipt.Items.Add(string.Format("{0,08}{1,20}", "Game:", game));
                lstReceipt.Items.Add(string.Format("{0,08}{1,10}", "Days Rented:", totalDays));
                lstReceipt.Items.Add(string.Format("{0,08}{1,10:C}", "Total Charge:", totalCharge));
                lstReceipt.Items.Add("");
                lstReceipt.Items.Add(string.Format("{0, 10}", "Thank You!"));
                lstReceipt.Items.Add("");

                lstReceipt.Items.Add(string.Format("{0,08}{1,10}", "Games rented today are due on :",
                    currentDate.AddDays(5).ToShortDateString()));


            }
            catch
            {
                MessageBox.Show("An Error Occured", "Error");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Clears the information and resets the date to current date

            lstReceipt.Items.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPlatform.Clear();
            txtTitle.Clear();
            dtpRentDate.Value = DateTime.Now;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the Application

            this.Close();
        }

        
    }
}
