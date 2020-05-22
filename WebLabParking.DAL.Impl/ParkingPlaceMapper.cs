using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebLabParking.Entities;
using WebLabParking.Models;

namespace WebLabParking.DAL.Impl
{
    public class ParkingPlaceMapper
    {
        //ParkingPlaceRepository parkingPlaceRepository = new ParkingPlaceRepository();
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
            ////ParkingPlace parkingPlace = parkingPlaceRepository.GetAll().ToList().Find(x => x.id == parkingPlaceDTO.id);
            //parkingPlace.Number = parkingPlaceDTO.Number;
            //ParkingTicketMapper parkingTicketMapper = new ParkingTicketMapper();
            //parkingPlace.Ticket = parkingTicketMapper.ParkingTicketDTOToParkingTicket(parkingPlaceDTO.Ticket);
            return new ParkingPlace();
        }
    }
}
