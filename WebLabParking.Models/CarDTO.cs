﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebLabParking.Models
{
    public class CarDTO
    {
        public string Name { get; set; }
        public List<ParkingTicketDTO> Tickets { get; set; }
    }
}