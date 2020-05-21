using System;
using System.Collections.Generic;
using System.Text;

namespace WebLabParking.Entities
{
    public class Parking
    {
        public string ParkingName { get; set; }
        public List<ParkingTicket> Tickets { get; set; }
        public List<ParkingPlace> Places { get; set; }
    }
}
