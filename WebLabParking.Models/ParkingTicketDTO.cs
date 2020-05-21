using System;
using System.Collections.Generic;
using System.Text;

namespace WebLabParking.Models
{
    public class ParkingTicketDTO
    {
        public DateTime LeavingTime { get; set; }//коли залишила
        public DateTime TakingTime { get; set; }//коли забрала
        //public ParkingPlaceDTO ParkingPlace { get; set; }
        //public CarDTO Car { get; set; }
        //public ClientDTO Client { get; set; }
    }
}
