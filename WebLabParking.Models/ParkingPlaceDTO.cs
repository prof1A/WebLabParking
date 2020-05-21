using System;
using System.Collections.Generic;
using System.Text;

namespace WebLabParking.Models
{
    public class ParkingPlaceDTO
    {
        public int Number { get; set; }
        public ParkingTicketDTO Ticket { get; set; }
    }
}
