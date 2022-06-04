using System;
using System.Collections.Generic;
using System.Text;

namespace Rebu
{
    public class Address
    {
        public Address(float latitude, float longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}
