using System;

namespace CSharp.Activity.Events
{
    class Program
    {
        static void Main(string[] args)
        {

            TrainStation trainStation = new TrainStation();
            var arrsub1 = new ArrivalSubscriber(trainStation);
            var arrsub2 = new ArrivalSubscriber(trainStation);

            trainStation.AnnounceArrival(1, 0, DateTime.Now);

           
        }

    }
}
