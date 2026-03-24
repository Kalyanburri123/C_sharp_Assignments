using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritence
{
    class User:IBookRide,ICancelRide,ICalculateFare
    {
        public int UserId;
        public string Username;
        public int RideId;
        public void BookRide(string source,string destination,int RideId)
        {
            Console.WriteLine("Enter source");
            source = Console.ReadLine();
            Console.WriteLine("Enter Destination");
            destination = Console.ReadLine();

            //Making validation until valid source and destinations are entered.
            while (string.IsNullOrWhiteSpace(source) || string.IsNullOrWhiteSpace(destination)||source.ToLower()==destination.ToLower())
            {
                Console.WriteLine("Invalid Source or Destination,Choose appropriate Souce/Destination.");
                Console.WriteLine("Enter source again");
                source = Console.ReadLine();
                Console.WriteLine("Enter Destination again");
                destination = Console.ReadLine();
            }

            //Generating a random Ride Id.
            this.RideId = Random.Shared.Next(1, 100000);

            Console.WriteLine("Your ride id is: " + this.RideId);
            Console.WriteLine("Your ride is successfully booked from:" + source + " to " + destination);
        }

        public void CancelRide(int BookingId)
        {
            Console.WriteLine("Enter Ride Id to Cance the Ride");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid Ride ID");
                return;
            }

            //Cancel the until the id entered is equals to Ride Id.
            while(id==null||id!=RideId)
            {
                Console.WriteLine("Incorrect Ride id, Please enter valid Ride id");
                id = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Success!,Your ride is Canceled");
        }

        public double CalculateFare(double distance)
        {
            Console.WriteLine("Enter distance in Km:");
            if (!double.TryParse(Console.ReadLine(), out double distanceInKm))
            {
                Console.WriteLine("Invalid input");
                return 0;
            }
            while(distanceInKm<=0)
            {
                Console.WriteLine("Distance from source to destination should be greater than 0 km ");
                distanceInKm = int.Parse(Console.ReadLine());
            }

            //Calculating the Fare by charging 7 Rs per Kilometer.
            return distanceInKm * 7;
        }
    }
}
