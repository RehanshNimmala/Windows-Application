//Programmer Name: Naveen Nimmala
// Project Name: Exercise 8
//Description : Selection controls


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimmalaExercise8
{
    public partial class SelectionControlForm : Form
    {
        public SelectionControlForm()
        {
            InitializeComponent();
        }
        
        private void btnSignup_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lstDisplay.Items.Add("Name:" + "" + name);
            lstDisplay.Items.Add("Event Preferences:");//selecting the events using the check boxes
           if (chkBratFry.Checked == true)
            {
                lstDisplay.Items.Add("Brat Fry");
            }
            if (chkBakeSale.Checked == true)
            {
                lstDisplay.Items.Add("Bake sale");
            }
            if (chkGolfing.Checked == true)
            {
                lstDisplay.Items.Add("Golfing");
            }
            if (chkWalkathon.Checked == true)
            {
                lstDisplay.Items.Add("Walkathon");
            }
           
            if (rdbFtt.Checked == true)//Selecting the number of hours using radio button
            {
                lstDisplay.Items.Add("Hours/week:" + "" + "5-10");
            }
            else if (rdbEtt.Checked == true)
            {
                lstDisplay.Items.Add("Hours/week:" + "" + "11-20");
            }
            else if (rdbTtt.Checked == true)
            {
                lstDisplay.Items.Add("Hours/week:" + "" + "21-30");
            }
            else if (rdbTtf.Checked == true)
            {
                lstDisplay.Items.Add("Hours/week:" + "" + "31-40");
            }
            else
            {
                MessageBox.Show(" Please select the number of hours");
            }
            if(rdbNew.Checked==true)//Selecting the status using radio button
            {
                lstDisplay.Items.Add("Status:" + "" + "New");
            }
           else if (rdbExperienced.Checked == true)
            {
                lstDisplay.Items.Add("Status:" + "" + "Experienced");
            }
            else
            {
                MessageBox.Show("Please select Valid status Value");
            }
            if(cboStatus.SelectedIndex==0) //selecting the optins using combo boxes
            {
                lstDisplay.Items.Add("Heard about us From" + "" + "Flyers");
            }
            else if (cboStatus.SelectedIndex == 1)
            {
                lstDisplay.Items.Add("Heard about us From" + "" + "Friends or family");
            }
            else if (cboStatus.SelectedIndex == 2)
            {
                lstDisplay.Items.Add("Heard about us From" + "" + "Email advertisement");
            }
            else if (cboStatus.SelectedIndex == 3)
            {
                lstDisplay.Items.Add("Heard about us From" + "" + "Website advertisement");
            }
            else
            {
                MessageBox.Show("Please select the source");
            }
        }
    }
}
