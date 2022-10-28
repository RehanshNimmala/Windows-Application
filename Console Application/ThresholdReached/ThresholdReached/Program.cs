using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThresholdReached
{
    internal class ThresholdReachedConsole
    {
        static void Main(string[] args)
        {
            //Instantiate the Counter class
            Counter counter= new Counter(new Random().Next(10));
            //passing a random number for threshold
            // The objective is you are counting for howmany time you press the 'a' key.
            //if you press it for>= the random numberthreshold, the event will fire.
            //So, the event you are watching for is: pressing 'a'that many number of times.
            counter.ThresholdReached += ThresholdMessage;//Multicast delegte
            Console.WriteLine("Press 'a' key to increase total");
            while(Console.ReadKey(true).KeyChar=='a')
            {
                Console.WriteLine("Adding one more 'a'");
                counter.Add(1);//Add method keeps the track of threshold and total, and raises the event
            }//while
            void ThresholdMessage(Object sender,ThresholdReachedEventArgs e)
            {
                //When the threshold is reached, a message is displayed.
                Console.WriteLine($"The threshold of {e.Threshold} was reached at {e.TimeReached}.");
                Console.ReadKey();
                Environment.Exit(0);//Exits the application
            }//ThreshodMessage

        }//Main()
    }//class

    class Counter
    {
        // This class stores the threshold number
        //When the threshold is passsed, calls the ThresholdReachedEventArgs class and passes the event data.
        private int threeshold;
        private int total;
        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
        //Event named ThresholdReached is defined.all events are of type EventHandler<>, which itself a delegate.That is why events are also delegates.
        public Counter(int thresholdPassed)
        {
            threeshold= thresholdPassed;
        }//ctor
        public void Add(int x)
        {
            //add method keeps on adding the incoming number to the total.if the total exceeds the threshold, then raises the event ThresholdReachedEventArgs.
            total += x;// This will add one to the total everytime 'a' is pressed.
            if(total >= threeshold)
            {
                //event threshold reached: setting the values for the threshold and time threshold reached.
                ThresholdReachedEventArgs tArgs = new ThresholdReachedEventArgs();
                //send data for Args
                tArgs.Threshold = threeshold;//threshold property for Args
                tArgs.TimeReached = DateTime.Now;//set current time

                //What should happen when threshold is reached? 
                // onthresholdReached(0 method should be called-- which in turn raises the threshold reached event.
                // call OnThresholdReached to raise the thresholdReachedEvent.

                OnThresholdReached(tArgs);//event raised
            }//if
        }//Add()
        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            // this method creates the delegate object of type event---ThresholdReacheEvent
            EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
            //EventHandler is a delegate that takes two arguments(Object sender and eventArgs e (i.e.,event data))
            if(handler!= null)
            {
                handler(this, e);
            }
        }
    }//Counter class

    class ThresholdReachedEventArgs : EventArgs
    {
        /* this class has two arguments, or data about the event:
         * 1.What is the threshold? an integer
         * 2.When was the threshold reached? Time
         */
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }

    }//class ThresholdReachedEventArgs
}//Namespace
