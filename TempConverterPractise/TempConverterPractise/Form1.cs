namespace TempConverterPractise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            decimal temperature;
            decimal celcius;
            decimal farenhiet;
            TempConverter tempConverter = new TempConverter();
            string result;
            if (decimal.TryParse(temperatureTextBox.Text, out temperature))
                {

                if (farenhietRadioButton.Checked == true) //user entered farenhiet, So Fto C method shall be called from TempConverter class
                {
                    celcius = tempConverter.FtoC(temperature);
                    result = temperature.ToString("N3") + "degree Farenheits=" + celcius.ToString("N3") + " degree Celcius";
                    resultLabel.Text = result;// Displaying the result in label
                }
                else if (celciusRadioButton.Checked == true)// User entered celcius, So CtoF method to be called from class TempConverter
                {
                    farenhiet = tempConverter.CtoF(temperature);
                    result = temperature.ToString("N3") + "degree celcius=" + farenhiet.ToString("N3") + " degree Farenheits";

                    resultLabel.Text = result;// Displaying the result in label
                }
                else
                {
                    //If radio button not checked
                    resultLabel.Text = "Please select the celcius or Farenhiet";
                }// End of radio button sction
            }
            else
            {
                resultLabel.Text=("Please enter the valid temperature");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            temperatureTextBox.Clear();
            celciusRadioButton.Checked= false;
            farenhietRadioButton.Checked= false;
            resultLabel.Text = "";
        }
    }
}