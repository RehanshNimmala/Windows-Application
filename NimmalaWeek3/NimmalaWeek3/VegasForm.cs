using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Created by Nimmala
namespace NimmalaWeek3
{
    public partial class VegasForm : Form
    {
        public VegasForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();

        }// Exit button

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            //Instantiate the class
            VegasClass vegasClass = new VegasClass();

            //variables for dice and sum
            int myDie1;
            int myDie2;
            int rollSum;

            //call the roll method and assign the value to sum
            rollSum=vegasClass.Roll(out myDie1, out myDie2);

            //Display the results

            die1Label.Text=myDie1.ToString();
            die2Label.Text=myDie2.ToString();
            sumLabel.Text=rollSum.ToString();

        }//Roll Dice Button
    }// end of class
}//end of namespace
