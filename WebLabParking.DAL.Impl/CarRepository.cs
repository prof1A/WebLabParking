using System.Collections.Generic;
using WebLabParking.DAL.Abstract;
using WebLabParking.Entities;
using System.Linq;

namespace WebLabParking.DAL.Impl
{
    public class CarRepository : ICarRepository
    {
        private ParkingContext context;

        public CarRepository(ParkingContext parkingContext)
        {
            context = parkingContext;
        }
        public void Create(Car obj)
        {
            context.Cars.Add(obj);
            context.SaveChanges();
        }

        public void Delete(string name)
        {
            context.Cars.Remove(context.Cars.ToList().Find(x=>x.Name==name));
            context.SaveChanges();
        }

        public Car Read()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Car obj)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Car> GetAll()
        {
            return context.Cars;
        }
    }
}