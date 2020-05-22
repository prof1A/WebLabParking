using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebLabParking.Entities;
using WebLabParking.Models;

namespace WebLabParking.DAL.Impl
{
    public class CarMapper
    {
        //CarRepository carRepository = new CarRepository();
        public CarDTO CarToCarDTO(Car car)
        {
            CarDTO carDTO = new CarDTO();
            carDTO.Name = car.Name;
            //carDTO.id = car.id;
            carDTO.Tickets = new List<ParkingTicketDTO>();
            ParkingTicketMapper parkingTicketMapper = new ParkingTicketMapper();
            foreach (var i in car.Tickets)
            {
                carDTO.Tickets.Add(parkingTicketMapper.ParkingTicketToParkingTicketDTO(i));
            }

            return carDTO;
        }

        public Car CarDTOToCar(CarDTO carDTO)
        {
            ////Car car = carRepository.GetAll().ToList().Find(x => x.id == carDTO.id);
            //car.Name = carDTO.Name;
            //car.Tickets = new List<ParkingTicket>();
            //ParkingTicketMapper parkingTicketMapper = new ParkingTicketMapper();
            //foreach (var i in carDTO.Tickets)
            //{
            //    car.Tickets.Add(parkingTicketMapper.ParkingTicketDTOToParkingTicket(i));
            //}

            return new Car();
        }
    }
}
