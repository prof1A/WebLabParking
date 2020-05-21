using System.Collections.Generic;
using WebLabParking.DAL.Abstract;
using WebLabParking.Entities;

namespace WebLabParking.DAL.Impl
{
    public class ClientRepository : IClientRepository
    {
        public List<Client> db = new List<Client>();

        public ClientRepository()
        {
            foreach (var i in DataBaseSimulation.clients)
            {
                db.Add(i);
            }
        }
        public void Create(Client obj)
        {
            db.Add(obj);
        }

        public void Delete(string name)
        {
            db.Remove(db.Find(x => x.Name == name));
            DataBaseSimulation.clients.Remove(DataBaseSimulation.clients.Find(x => x.Name == name));
        }
        public Client Read(string name)
        {
            return DataBaseSimulation.clients.Find(x=>x.Name==name);
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
            return db;
        }
    }
}