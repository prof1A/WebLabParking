using System.Collections.Generic;
using WebLabParking.BLL.Abstract;
using WebLabParking.DAL.Abstract;
using WebLabParking.DAL.Impl;
using WebLabParking.Entities;
using WebLabParking.Models;

namespace WebLabParking.BLL.Impl
{
    public class ClientService:IClientService
    {
        public IClientRepository ClientRepository;
        public ClientMapper mapper = new ClientMapper();
        public ClientService(IClientRepository ClientRepository)
        {
            this.ClientRepository = ClientRepository;
        }
        public void Create(ClientDTO obj)
        {
            Client Client = mapper.ClientDTOToClient(obj);
            ClientRepository.Create(Client);
        }

        public void Delete(string name)
        {
            ClientRepository.Delete(name);
        }

        public IEnumerable<ClientDTO> GetAll()
        {
            List<ClientDTO> Clients = new List<ClientDTO>();
            foreach (var i in ClientRepository.GetAll())
            {
                Clients.Add(mapper.ClientToClientDTO(i));
            }

            return Clients;
        }

        public ClientDTO Read(string name)
        {
            return mapper.ClientToClientDTO(ClientRepository.Read(name));
        }

        public ClientDTO Read()
        {
            throw new System.NotImplementedException();
        }

        public void Update(ClientDTO obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
