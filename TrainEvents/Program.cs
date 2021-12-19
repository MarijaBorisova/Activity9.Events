using System;

namespace CSharp.Activity.Events
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainStation trainStation = new TrainStation();
            trainStation.Arrival += new EventHandler(AnnounceArrival);
        }

    }
}
