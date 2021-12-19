using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace CSharp.Activity.Events
{
    public class TrainStation
    {
        ArrivalEventArgs e = new ArrivalEventArgs(1, 0, DateTime.Now);

        //The event field declaration. Raises the Arrival event
        public event EventHandler<ArrivalEventArgs> Arrival;

        //method would raise the event Arrival.
        protected void OnArrival(ArrivalEventArgs e)
        {

            if (this. Arrival != null)
              {
                  this. Arrival(this, e);

              }
           

        }

        //method would be called by the clients.From this method invoke the method
        //OnArrival() by passing a new instance of ArrivalEventArgs.
        public void AnnounceArrival(int train, ArrivalStatus arrivalStatus, DateTime arrivalTime)
        {
            OnArrival(this, new ArrivalEventArgs(train, ArrivalStatus.Arrived, arrivalTime));
        }
    }

        //To test the event, you should declare an object of type TrainStation,
        //instantiate it, subscribe to the Arrival event and activate this event by
        //calling method AnnounceArrival(). The class must declare an event
        //handler method, e.g., void ArrivalHandler(object sender, ArrivalEventArgs args) that responds to these events.
        public class ArrivalSubscriber
        {
            //TrainStation trainStation = new TrainStation();
            public ArrivalSubscriber(TrainStation trainStation)
            {
                trainStation.Arrival += new EventHandler(AnnounceArrival(1, 0, DateTime.Now)); 
                
            }

            void ArrivalHandler(object trainStation, ArrivalEventArgs e)
            {
            if (e.train)
            {
                Console.WriteLine($"The train {e.train}, is {e.arrivalStatus}, at {e.DateTime.arrivalTime} ");
            }
                
            Console.WriteLine($"The Train is: {e}");
            }
        }
    
    }



