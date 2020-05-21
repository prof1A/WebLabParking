using System;
using System.Collections.Generic;
using System.Text;
using WebLabParking.Entities;
using WebLabParking.Models;

namespace WebLabParking.DAL.Impl
{
    public class ClientMapper
    {
        public ClientDTO ClientToClientDTO(Client client)
        {
            ClientDTO clientDTO = new ClientDTO();
            clientDTO.Name = client.Name;
            clientDTO.Tickets = new List<ParkingTicketDTO>();
            ParkingTicketMapper parkingTicketMapper = new ParkingTicketMapper();
            foreach (var i in client.Tickets)
            {
                clientDTO.Tickets.Add(parkingTicketMapper.ParkingTicketToParkingTicketDTO(i));
            }

            return clientDTO;
        }

        public Client ClientDTOToClient(ClientDTO clientDTO)
        {
            Client client = new Client();
            client.Name = clientDTO.Name;
            client.Tickets = new List<ParkingTicket>();
            ParkingTicketMapper parkingTicketMapper = new ParkingTicketMapper();
            foreach (var i in clientDTO.Tickets)
            {
                client.Tickets.Add(parkingTicketMapper.ParkingTicketDTOToParkingTicket(i));
            }

            return client;
        }
    }
}
