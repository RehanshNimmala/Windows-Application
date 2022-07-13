//Programmer name: Naveen Nimmala
//Project name: Exercise 2
//Description: Display a greeting

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimmalaEX2
{
    public partial class GreetingForm : Form
    {
        public GreetingForm()
        {
            InitializeComponent();
        }

        private void btnResetGreeting_Click(object sender, EventArgs e)
        {
            //Resets the Greeting
            lblGreeting.Text = "";
        }

        private void btnDisplayGreeting_Click(object sender, EventArgs e)
        {
            //Displays  Hello World in the label
            lblGreeting.Text = "Hello World!";
        }
    }
}
