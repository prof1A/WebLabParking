using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebLabParking.Entities
{
    public class ParkingTicket
    {
        [Key]
        public int id { get; set; }
        [Required]
        public DateTime LeavingTime { get; set; }//коли залишила
        [Required]
        public DateTime TakingTime { get; set; }//коли забрала
        [ForeignKey("ClientID")]
        public Client Client { get; set; }
        //public ParkingPlace ParkingPlace { get; set; }
        //public Car Car { get; set; }
        //public Client Client { get; set; }
    }
}
