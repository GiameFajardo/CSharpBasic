using Rebu;
using System;
using System.Collections.Generic;
using System.Text;

namespace RebuApp.Services
{
    public static class TripService
    {

        public static Trip CreateTrip(
            float initialLat, 
            float initialLon, 
            float destinationLat, 
            float destinationLon)
        {
            var initialAddress = new Address(initialLat, initialLon);
            var destinationAddress = new Address(destinationLat, destinationLon);

            Trip trip = new Trip(initialAddress, destinationAddress);

            return trip;
        }
    }
}
