using System;
using System.Collections.Generic;
using System.Text;

namespace WebLabParking.Models
{
    public class ParkingDTO
    {
        public int id { get; set; }
        public string ParkingName { get; set; }
        public List<ParkingTicketDTO> Tickets { get; set; }
        public List<ParkingPlaceDTO> Places { get; set; }
    }
}
