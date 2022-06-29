//Programmer Name: Naveen Nimmala
//Project Name: Community Room Reservation
//Description: Allocating the Community rooms for rental purpose



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimmalaAssign2
{
    public partial class RoomReservation : Form
    {
        public RoomReservation()
        {
            InitializeComponent();
        }
        //Scope of variable
        double totalRevenue = 0;
        int count;
        private void btnCompleteReservation_Click(object sender, EventArgs e)
        {
            //Exception Handling
            try
            {
                //Display Variables
                string customerName;
                int numberOfHours;
                int roomNumber;
                double rentalCharge;
                double totalCharge;
                const int HOUR_CHARGE = 110;
                const int RESERVATION_FEE = 20;


                // input

                customerName = txtCustomerName.Text;
                numberOfHours = int.Parse(txtNumberOfHours.Text);
                roomNumber = int.Parse(txtRoomNumber.Text);


                //processing

                rentalCharge = numberOfHours * HOUR_CHARGE;
                totalCharge = rentalCharge + RESERVATION_FEE;
                totalRevenue = totalRevenue + totalCharge;
                count = count + 1;

                //output
                lstConfirmation.Items.Add(string.Format("{0,12}", "Reservation Confirmed"));
                lstConfirmation.Items.Add(string.Format(""));
                lstConfirmation.Items.Add(string.Format("{0,12}{1,8}", "Customer Name:", customerName));
                lstConfirmation.Items.Add(string.Format("{0,12}{1,8}", "Room Number:", roomNumber));
                lstConfirmation.Items.Add(string.Format("{0,12}{1,8}", "Rental Charge:", rentalCharge));
                lstConfirmation.Items.Add(string.Format("{0,12}{1,8}", "Reservation Charge:", RESERVATION_FEE));
                lstConfirmation.Items.Add(string.Format("{0,12}{1,8:C}", "Total Charge:", totalCharge));
                lstConfirmation.Items.Add(string.Format("-----------------------------------------"));
                lstConfirmation.Items.Add(string.Format("{0,20}","Thank You!"));


            }
            catch
            {
                MessageBox.Show("An error occured during the execution","Error");
            }





        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Clears the content
            txtCustomerName.Clear();
            txtNumberOfHours.Clear();
            txtRoomNumber.Clear();
            lstConfirmation.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the content
            this.Close();
        }

        private void btnDisplayReservationReport_Click(object sender, EventArgs e)
        {
            //Output
            lstConfirmation.Items.Add(string.Format("{0,12}", "Summary Report" ));
            lstConfirmation.Items.Add(string.Format("---------------------------"));

            lstConfirmation.Items.Add(string.Format("{0,12}{1,4}", "Number of Reservations:", count));
            lstConfirmation.Items.Add(string.Format("{0,12}{1,8:C}", "Total Revenue:", totalRevenue));


        }
    }
}
