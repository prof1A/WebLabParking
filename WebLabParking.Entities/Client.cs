using System;
using System.Collections.Generic;
using System.Text;

namespace WebLabParking.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public List<ParkingTicket> Tickets { get; set; }
    }
}
