using System;
using System.Collections.Generic;
using System.Text;

namespace WebLabParking.Entities
{
    public class ParkingTicket
    {
        public DateTime LeavingTime { get; set; }//коли залишила
        public DateTime TakingTime { get; set; }//коли забрала
        public ParkingPlace ParkingPlace { get; set; }
        public Car Car { get; set; }
        public Client Client { get; set; }
    }
}
