using System.Collections.Generic;
using WebLabParking.BLL.Abstract;
using WebLabParking.DAL.Abstract;
using WebLabParking.DAL.Impl;
using WebLabParking.Entities;
using WebLabParking.Models;

namespace WebLabParking.BLL.Impl
{
    public class ParkingTicketService : IParkingTicketService
    {
        public IParkingTicketRepository ParkingTicketRepository;
        public ParkingTicketMapper mapper = new ParkingTicketMapper();
        public ParkingTicketService(IParkingTicketRepository ParkingTicketRepository)
        {
            this.ParkingTicketRepository = ParkingTicketRepository;
        }
        public void Create(ParkingTicketDTO obj)
        {
            ParkingTicket ParkingTicket = mapper.ParkingTicketDTOToParkingTicket(obj);
            ParkingTicketRepository.Create(ParkingTicket);
        }

        public void Delete(string name)
        {
            ParkingTicketRepository.Delete(name);
        }

        public IEnumerable<ParkingTicketDTO> GetAll()
        {
            List<ParkingTicketDTO> ParkingTickets = new List<ParkingTicketDTO>();
            foreach (var i in ParkingTicketRepository.GetAll())
            {
                ParkingTickets.Add(mapper.ParkingTicketToParkingTicketDTO(i));
            }

            return ParkingTickets;
        }

        public ParkingTicketDTO Read()
        {
            throw new System.NotImplementedException();
        }

        public void Update(ParkingTicketDTO obj)
        {
            throw new System.NotImplementedException();
        }
    }

}