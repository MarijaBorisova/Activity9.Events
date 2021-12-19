using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Events
{
    public class TrainStation
    {
        //The event field declaration. Raises the Arrival event
        public event EventHandler Arrival;

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
}
