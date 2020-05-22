using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebLabParking.Entities;
using WebLabParking.Models;

namespace WebLabParking.DAL.Impl
{
    public class ParkingMapper
    {
        //ParkingRepository parkingRepository = new ParkingRepository();
        public ParkingDTO ParkingToParkingDTO(Parking parking)
        {
            ParkingDTO parkingDTO = new ParkingDTO();
            parkingDTO.ParkingName = parking.ParkingName;
            //parkingDTO.id = parking.id;
            parkingDTO.Tickets = new List<ParkingTicketDTO>();
            parkingDTO.Places = new List<ParkingPlaceDTO>();
            ParkingTicketMapper parkingTicketMapper = new ParkingTicketMapper();
            ParkingPlaceMapper parkingPlaceMapper = new ParkingPlaceMapper();
            foreach (var i in parking.Tickets)
            {
                parkingDTO.Tickets.Add(parkingTicketMapper.ParkingTicketToParkingTicketDTO(i));
            }

            foreach (var i in parking.Places)
            {
                parkingDTO.Places.Add(parkingPlaceMapper.ParkingPlaceToParkingPlaceDTO(i));
            }

            return parkingDTO;
        }

        public Parking ParkingDTOToParking(ParkingDTO parkingDTO)
        {
            ////Parking parking = parkingRepository.GetAll().ToList().Find(x => x.id == parkingDTO.id);

            //parking.ParkingName = parkingDTO.ParkingName;
            //parking.Tickets = new List<ParkingTicket>();
            //parking.Places = new List<ParkingPlace>();
            //ParkingTicketMapper parkingTicketMapper = new ParkingTicketMapper();
            //ParkingPlaceMapper parkingPlaceMapper = new ParkingPlaceMapper();
            //foreach (var i in parkingDTO.Tickets)
            //{
            //    parking.Tickets.Add(parkingTicketMapper.ParkingTicketDTOToParkingTicket(i));
            //}

            //foreach (var i in parkingDTO.Places)
            //{
            //    parking.Places.Add(parkingPlaceMapper.ParkingPlaceDTOToParkingPlace(i));
            //}

            return new Parking();
        }
    }
}
