using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventForms
{
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
        }

        private void newCarDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Just rhe dealer class with new consumers

            var dealer = new CarDealer();
            //all syntax below is equivalent.You can use whatever you want to get the item selected from the combobox.
            //string carSelected=newCarComboBox.Text;
            //string carSelected=(string);
             carComboBox.SelectedItem;
            string carSelected = newCarComboBox.SelectedIndex.ToString();
            dealer.NewCar(carSelected);
        }// combo box selected index changed event

        private void goButton_Click(object sender, EventArgs e)
        {
            if(carComboBox.SelectedIndex == -1)
            {
                var dealer=new CarDealer();
                //consumers of type Consumer class.You have not yet called the ctor.
                Consumer Naveen;
                Consumer Navin;
                Consumer Nawin;
                Consumer Nabin;
                
                // subscribing customers for notification when a new car arrives:
                if(naveenCheckBox.Checked)
                {
                    Naveen = new Consumer(naveenCheckBox.Text);
                    dealer.NewCarInfo += Naveen.NewcarIsHere;//This is a multicast delegate that adds the NewcarIsHere method to the NewCarInfo mrthod.
                }
                if(navinCheckBox.Checked)
                {
                    Navin= new Consumer(navinCheckBox.Text);
                    dealer.NewCarInfo+=Navin.NewcarIsHere;//Multicast delegate
                }
                if (nawinCheckBox.Checked)
                {
                    Nawin = new Consumer(nawinCheckBox.Text);
                    dealer.NewCarInfo += Nawin.NewcarIsHere;//Multicast delegate
                }
                if (nabinCheckBox.Checked)
                {
                    Nabin = new Consumer(nabinCheckBox.Text);
                    dealer.NewCarInfo += Nabin.NewcarIsHere;//Multicast delegate
                }
                // In the above steps, you have only instantiated the CarDelaer class, and you have subscribed consumers to be notified when the new car arrives.
                //Just instantiating is not going to raise the event.
                //The event is raised only when the new CarDealer method is called.
            }//if
        }//Go button

        private void Dealer_NewCarInfo(object sender, CarInfoEventArgs e)
        {
            throw new NotImplementedException();
        }
    }//form
}
