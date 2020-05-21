using System;
using System.Collections.Generic;
using System.Text;
using WebLabParking.Entities;
using WebLabParking.Models;

namespace WebLabParking.DAL.Impl
{
    public class ParkingPlaceMapper
    {
        public ParkingPlaceDTO ParkingPlaceToParkingPlaceDTO(ParkingPlace parkingPlace)
        {
            ParkingPlaceDTO parkingPlaceDTO = new ParkingPlaceDTO();
            parkingPlaceDTO.Number = parkingPlace.Number;
            ParkingTicketMapper parkingTicketMapper = new ParkingTicketMapper();
            parkingPlaceDTO.Ticket = parkingTicketMapper.ParkingTicketToParkingTicketDTO(parkingPlace.Ticket);
            return parkingPlaceDTO;
        }

        public ParkingPlace ParkingPlaceDTOToParkingPlace(ParkingPlaceDTO parkingPlaceDTO)
        {
            ParkingPlace parkingPlace = new ParkingPlace();
            parkingPlace.Number = parkingPlaceDTO.Number;
            ParkingTicketMapper parkingTicketMapper = new ParkingTicketMapper();
            parkingPlace.Ticket = parkingTicketMapper.ParkingTicketDTOToParkingTicket(parkingPlaceDTO.Ticket);
            return parkingPlace;
        }
    }
}
