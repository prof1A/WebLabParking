using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebLabParking.Entities
{
    public class ParkingPlace
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Number { get; set; }
        public ParkingTicket Ticket { get; set; }
    }
}
