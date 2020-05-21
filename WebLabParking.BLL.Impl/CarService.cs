using System.Collections.Generic;
using WebLabParking.BLL.Abstract;
using WebLabParking.DAL.Abstract;
using WebLabParking.DAL.Impl;
using WebLabParking.Entities;
using WebLabParking.Models;

namespace WebLabParking.BLL.Impl
{
    public class CarService : ICarService
    {
        public ICarRepository carRepository;
        public CarMapper mapper = new CarMapper();
        public CarService(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }
        public void Create(CarDTO obj)
        {
            Car car = mapper.CarDTOToCar(obj);
            carRepository.Create(car);
        }

        public void Delete(string name)
        {
            carRepository.Delete(name);
        }

        public IEnumerable<CarDTO> GetAll()
        {
            List<CarDTO> cars = new List<CarDTO>();
            foreach (var i in carRepository.GetAll())
            {
                cars.Add(mapper.CarToCarDTO(i));
            }

            return cars;
        }

        public CarDTO Read()
        {
            throw new System.NotImplementedException();
        }

        public void Update(CarDTO obj)
        {
            throw new System.NotImplementedException();
        }
    }
}