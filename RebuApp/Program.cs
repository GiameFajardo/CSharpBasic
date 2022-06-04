using Rebu;
using RebuApp.Services;
using System;

namespace RebuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passenger passenger1 = new Passenger();
            passenger1.Name = "Pablo";
            passenger1.Identifier = "xxxxxx";
            passenger1.Photo = "url";
            passenger1.Phone = "80925555564";

            Passenger passenger2 = new Passenger();
            passenger2.Name = "Jose";
            passenger2.Identifier = "xxxxxx";
            passenger2.Photo = "url";
            passenger2.Phone = "8295554441";

            Passenger passenger3 = new Passenger("Giame");
            Passenger passenger4 = new Passenger(
                "Carlos",
                "123123123",
                "url",
                "8095554444"
                );
            Passenger passenger5 = new Passenger
            {
                Name = "",
                Identifier = "",
                Photo = "url",
                Phone = ""
            };
            Passenger p = new Passenger();
            
            var trip = TripService.CreateTrip(15,54,8,45);

        }
    }
}
