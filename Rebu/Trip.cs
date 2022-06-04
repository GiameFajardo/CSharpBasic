using System;
using System.Collections.Generic;
using System.Text;

namespace Rebu
{
    public class Trip
    {

        public Trip(Address source, Address destino)
        {
            this.dirSource = source;
            this.dirDestin = destino;
        }
        public Address dirSource { get; set; }
        public Address dirDestin { get; set; }
        public string tipoServicio { get; set; }
        public int ETA { get; set; }
        public int RTA { get; set; }
        public DateTime horaStart { get; set; }
        public DateTime horaEnd { get; set; }
        public float tarifaEta { get; set; }
        public float tarifaRta { get; set; }
        public float distancia { get; set; }
        public string status { get; set; }

    }
}
