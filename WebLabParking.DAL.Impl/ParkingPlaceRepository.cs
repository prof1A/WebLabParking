using System.Collections.Generic;
using System.Linq;
using WebLabParking.DAL.Abstract;
using WebLabParking.Entities;

namespace WebLabParking.DAL.Impl
{
    public class ParkingPlaceRepository:IParkingPlaceRepository
    {
        private ParkingContext context;

        public ParkingPlaceRepository(ParkingContext parkingContext)
        {
            context = parkingContext;
        }
        public void Create(ParkingPlace obj)
        {
            context.ParkingPlaces.Add(obj);
            context.SaveChanges();
        }

        public void Delete(string name)
        {
            context.ParkingPlaces.Remove(context.ParkingPlaces.ToList().Find(x => x.Number.ToString() == name));
            context.SaveChanges();
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