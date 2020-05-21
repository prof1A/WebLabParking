using System.Collections.Generic;
using WebLabParking.BLL.Abstract;
using WebLabParking.DAL.Abstract;
using WebLabParking.DAL.Impl;
using WebLabParking.Entities;
using WebLabParking.Models;

namespace WebLabParking.BLL.Impl
{
    public class ParkingService : IParkingService
    {
        public IParkingRepository ParkingRepository;
        public ParkingMapper mapper = new ParkingMapper();
        public ParkingService(IParkingRepository ParkingRepository)
        {
            this.ParkingRepository = ParkingRepository;
        }
        public void Create(ParkingDTO obj)
        {
            Parking Parking = mapper.ParkingDTOToParking(obj);
            ParkingRepository.Create(Parking);
        }

        public void Delete(string name)
        {
            ParkingRepository.Delete(name);
        }

        public IEnumerable<ParkingDTO> GetAll()
        {
            List<ParkingDTO> Parkings = new List<ParkingDTO>();
            foreach (var i in ParkingRepository.GetAll())
            {
                Parkings.Add(mapper.ParkingToParkingDTO(i));
            }

            return Parkings;
        }

        public ParkingDTO Read()
        {
            throw new System.NotImplementedException();
        }

        public void Update(ParkingDTO obj)
        {
            throw new System.NotImplementedException();
        }
    }
}