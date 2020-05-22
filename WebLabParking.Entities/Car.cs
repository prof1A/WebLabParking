using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebLabParking.Entities
{
    public class Car
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public List<ParkingTicket> Tickets { get; set; }
    }
}
