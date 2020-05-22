using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebLabParking.Entities
{
    public class Parking
    {
        [Key]
        public int id { get; set; }
        public string ParkingName { get; set; }
        public List<ParkingTicket> Tickets { get; set; }
        public List<ParkingPlace> Places { get; set; }
    }
}
