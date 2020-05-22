using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebLabParking.Entities;
using WebLabParking.Models;

namespace WebLabParking.DAL.Impl
{
    public class ClientMapper
    {
        //ClientRepository clientRepository = new ClientRepository();
        public ClientDTO ClientToClientDTO(Client client)
        {
            ClientDTO clientDTO = new ClientDTO();
            clientDTO.Name = client.Name;
            //clientDTO.id = client.id;
            clientDTO.Tickets = new List<ParkingTicketDTO>();
            ParkingTicketMapper parkingTicketMapper = new ParkingTicketMapper();
            //foreach (var i in client.Tickets)
            //{
            //    clientDTO.Tickets.Add(parkingTicketMapper.ParkingTicketToParkingTicketDTO(i));
            //}

            return clientDTO;
        }

        public Client ClientDTOToClient(ClientDTO clientDTO)
        {
            ////Client client = clientRepository.GetAll().ToList().Find(x => x.id == clientDTO.id);
            //client.Name = clientDTO.Name;
            //client.id = clientDTO.id;
            //client.Tickets = new List<ParkingTicket>();
            //ParkingTicketMapper parkingTicketMapper = new ParkingTicketMapper();
            //foreach (var i in clientDTO.Tickets)
            //{
            //    client.Tickets.Add(parkingTicketMapper.ParkingTicketDTOToParkingTicket(i));
            //}

            return new Client();
        }
    }
}
