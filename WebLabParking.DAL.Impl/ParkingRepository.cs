using System.Collections.Generic;
using WebLabParking.DAL.Abstract;
using WebLabParking.Entities;

namespace WebLabParking.DAL.Impl
{
    public class ParkingRepository:IParkingRepository
    {
        public List<Parking> db;

        public ParkingRepository()
        {
            db = DataBaseSimulation.parkings;
        }
        public void Create(Parking obj)
        {
            db.Add(obj);
        }

        public void Delete(string name)
        {
            db.Remove(db.Find(x => x.ParkingName == name));
        }

        public Parking Read()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Parking obj)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Parking> GetAll()
        {
            return DataBaseSimulation.parkings;
        }
    }
}