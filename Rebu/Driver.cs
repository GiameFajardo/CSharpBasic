using System;
using System.Collections.Generic;
using System.Text;

namespace Rebu
{
    public class Driver
    {
        public Driver()
        {

        }
        public Driver(string name, Vehicle vehicle)
        {
            this.Name = name;
            this.Vehiculo = vehicle;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public string Photo { get; set; }
        public string Phone { get; set; }
        public bool Avalible { get; set; }
        public Vehicle Vehiculo { get; set; }
        public string PhoneNumber { get; set; }

    }
}
