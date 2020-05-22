using System.Collections.Generic;
using WebLabParking.DAL.Abstract;
using WebLabParking.Entities;

namespace WebLabParking.DAL.Impl
{
    public class ParkingTicketRepository : IParkingTicketRepository
    {
        public List<ParkingTicket> db = new List<ParkingTicket>();

        public ParkingTicketRepository()
        {
            foreach (var i in DataBaseSimulation.parkingTickets)
            {
                db.Add(i);
            }
        }
        public void Create(ParkingTicket obj)
        {
            //DataBaseSimulation.parkingTickets.Add(obj);
        }

        public void Delete(string name)
        {
            throw new System.NotImplementedException();
        }

        public ParkingTicket Read()
        {
            throw new System.NotImplementedException();
        }

        public void Update(ParkingTicket obj)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ParkingTicket> GetAll()
        {
            return db;
        }
    }
}