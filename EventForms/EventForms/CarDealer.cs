using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventForms
{
    //Created by Nimmala
    //11111111111111

    //There are three classes in this file
    internal class CarDealer
    {
        //Car Dealer class has one event-- new car info.
        //This is the publisher class that publishes the newCarInfo event

        public event EventHandler<CarInfoEventArgs> NewCarInfo; // This is the event.recall: Event is a delegate

        public void NewCar(string car)
        {
            /*whenever a new car event occurs, that is, whenever the newCar method is called,
            it calls the method called RaiseNewCarInfo and supplies the argument car.*/
            RaiseNewCarInfo(car);

            System.Windows.Forms.MessageBox.Show($"Message from CarDealer class \r\n New Car Event happened by calling the CarDealer." +
                $"NewCar method.\r\n The new car selected is {car}.\r\rn" +
                $"Now RaisingNewcarInfo(car) method is called.");
        }//new car
        protected virtual void RaiseNewCarInfo(string car)
        {
            //This method RaiseNewCarInfo-- creates and instantiates the delegates i.e., the event handlers required 
            EventHandler<CarInfoEventArgs> newCarInfo = NewCarInfo;//delegate instance

            if(newCarInfo != null)
            {
                //calling the delegate instance and supplying two arguments.
                newCarInfo(this, new CarInfoEventArgs(car));// instantiating the delegate
            }//end if
        }//RaiseNewCarInfo
    }//CarDealer class

    class CarInfoEventArgs : EventArgs
    {
        /*
         EventArgs represents the base class for classes that contain event data and provides a value to use for events that do not include event data
        This class serves as the base class for all classes that represent event data.
        To create a custom event data class, create a class that derives from the EventArgs class and provide the properties to store the necessary data
        The name of your custom event dta class should end with EventArgs
          */

        public string Car { get; set; }//property
        public CarInfoEventArgs(string car)
        {
            Car = car;
        }//ctor
    }//CarInfoEventArgs

    class Consumer
    {
        /*This is the subscriber class that subscribes to the event NewCarInfo from the CarDealerClass
          */
        private string _consumerName;
        public Consumer(string Name)
        {
           this. _consumerName = Name;
        }//ctor
        /* This is the method that does something when the consumer subscribes to the newcar event.
         * Does this look similar to the event listeners that you create for every forms project? */

        public void NewcarIsHere(Object sender, CarInfoEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show($"You are receiving this message becauseyou are signed up for the NewCarInfo event." +
                $"You will receive this message when ever the NewCar method is called.\r\n " +
                $"The car:{e.Car} is brand new and downright.", this.GetType().Name);

        }//end NewcarIsHere
    }// End Consumer Class
}//End Namespace
