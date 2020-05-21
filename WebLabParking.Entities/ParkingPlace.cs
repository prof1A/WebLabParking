using System;
using System.Collections.Generic;
using System.Text;

namespace WebLabParking.Entities
{
    public class ParkingPlace
    {
        public int Number { get; set; }
        public ParkingTicket Ticket { get; set; }
    }
}
