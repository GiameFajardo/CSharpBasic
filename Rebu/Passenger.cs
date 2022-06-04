using System;
using System.Collections.Generic;
using System.Text;

namespace Rebu
{
    public class Passenger
    {
        public Passenger()
        {

        }
        public Passenger(string name)
        {
            this.Name = name;
        }
        public Passenger(int identifier)
        {
            this.Identifier = identifier.ToString();
        }
        public Passenger(string name, string identifier, string photo, string phone)
        {
            this.Name = name;
            this.Identifier = identifier;
            this.Photo = photo;
            this.Phone = phone;
        }
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string Photo { get; set; }
        public string Phone { get; set; }


    }
}
