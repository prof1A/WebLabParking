using System.Collections.Generic;
using WebLabParking.DAL.Abstract;
using WebLabParking.Entities;

namespace WebLabParking.DAL.Impl
{
    public class ParkingPlaceRepository:IParkingPlaceRepository
    {
        public List<ParkingPlace> db = new List<ParkingPlace>();

        public ParkingPlaceRepository()
        {
            foreach (var i in DataBaseSimulation.parkingsPlaces)
            {
                db.Add(i);
            }
        }
        public void Create(ParkingPlace obj)
        {
            db.Add(obj);
        }

        public void Delete(string name)
        {
            db.Remove(db.Find(x => x.Number.ToString() == name));
            DataBaseSimulation.parkingsPlaces.Remove(
                DataBaseSimulation.parkingsPlaces.Find((x => x.Number.ToString() == name)));
            foreach (var i in DataBaseSimulation.parkings)
            {
                i.Places.Remove(i.Places.Find(x => x.Number.ToString() == name));
            }
        }

        public ParkingPlace Read()
        {
            throw new System.NotImplementedException();
        }

        public void Update(ParkingPlace obj)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ParkingPlace> GetAll()
        {
            return DataBaseSimulation.parkingsPlaces;
        }
    }
}