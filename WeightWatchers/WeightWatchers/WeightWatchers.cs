using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightWatchers
{
    public partial class WeightWatchers : Form
    {
        public WeightWatchers()
        {
            InitializeComponent();
        }

        private void WeightWatchers_Load(object sender, EventArgs e)
        {
            // Instantiating the class
            Exercise exercise = new Exercise();
            caloriesListBox.Items.Add("Calories Burned - Moderate Exercise");
            caloriesListBox.Items.Add("Minutes\t Calories Burned");

            for(int i=5;i<60;i+=5)
            {
                caloriesListBox.Items.Add($"{i}\t{exercise.CaloriesBurnt(i).ToString("N")}");
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Implementing validations
            if(activityComboBox.SelectedIndex != -1)
            {
                int activity=activityComboBox.SelectedIndex;
                int duration;
                if ((Int32.TryParse(durationTextBox.Text, out duration) && (duration > 0))) 
                {
                    double weight;
                    if(double.TryParse(weightTextBox.Text, out weight)&& (weight>0))
                    {
                        //Instantiate class and display results
                        Exercise exercise=new Exercise();
                        //variables for calories burned & call method
                        double caloriesBurned=exercise.CaloriesBurned(activity,weight,duration);
                        caloriesBurntLabel.Text=$@"{activityComboBox.SelectedItem.ToString()} for {duration} minutes, burns  {caloriesBurned.ToString("N")} Calories";


                    }
                    else
                    {
                        caloriesBurntLabel.Text = "Please Enter a valid number for weight";
                    }
                }
                else
                {
                    caloriesBurntLabel.Text = "Please enter Duration as a valid integer";
                }

            }
            else
            {
                caloriesBurntLabel.Text = "Please select Activity and try again";
            }//End of combo box validation
        }// end of calculation

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }// end of Exit method
    }// end of class
}// end of Namespace
