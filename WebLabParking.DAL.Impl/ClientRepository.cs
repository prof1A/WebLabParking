using System.Collections.Generic;
using System.Linq;
using WebLabParking.DAL.Abstract;
using WebLabParking.Entities;

namespace WebLabParking.DAL.Impl
{
    public class ClientRepository : IClientRepository
    {
        private ParkingContext context;
        public ClientRepository(ParkingContext parkingContext)
        {
            context = parkingContext;
        }
        public void Create(Client obj)
        {
            context.Clients.Add(obj);
            context.SaveChanges();
        }

        public void Delete(string name)
        {
            context.Clients.Remove(context.Clients.ToList().Find(x => x.Name == name));
            context.SaveChanges();
        }
        public Client Read(string name)
        {
            return context.Clients.ToList().Find(x => x.Name == name);
        }
        public Client Read()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Client obj)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Client> GetAll()
        {
            return context.Clients;
        }
    }
}