using System.Collections.Generic;
using WebLabParking.DAL.Abstract;
using WebLabParking.Entities;

namespace WebLabParking.DAL.Impl
{
    public class CarRepository : ICarRepository
    {
        public List<Car> db = new List<Car>();

        public CarRepository()
        {
            foreach (var i in DataBaseSimulation.cars)
            {
                db.Add(i);
            }
        }
        public void Create(Car obj)
        {
            db.Add(obj);
        }

        public void Delete(string name)
        {
            db.Remove(db.Find(x=>x.Name==name));
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
            return db;
        }
    }
}