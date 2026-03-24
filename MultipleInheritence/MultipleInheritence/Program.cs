using System;
namespace MultipleInheritence
{
    class Program
    {
        public static void Main(string[] args)
        {
            User user = new User();

            //Making dummy data now and later we override them by assigning.
            string source = "";
            string destination = "";
            int rideId = 0;
            double distance = 0;

            //Booking the Ride.

            user.BookRide(source, destination, rideId);
            double Fare = user.CalculateFare(distance);

            //Checking the Fare.
            Console.WriteLine("Fare from Your Soucre to Destination is :" + Fare);

            //Cancel the Ride.
            user.CancelRide(rideId);
        }
    }
}