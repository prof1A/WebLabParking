using System.Collections.Generic;
using WebLabParking.BLL.Abstract;
using WebLabParking.DAL.Abstract;
using WebLabParking.DAL.Impl;
using WebLabParking.Entities;
using WebLabParking.Models;

namespace WebLabParking.BLL.Impl
{
    public class ParkingPlaceService:IParkingPlaceService
    {
        public IParkingPlaceRepository ParkingPlaceRepository;
        public ParkingPlaceMapper mapper = new ParkingPlaceMapper();
        public ParkingPlaceService(IParkingPlaceRepository ParkingPlaceRepository)
        {
            this.ParkingPlaceRepository = ParkingPlaceRepository;
        }
        public void Create(ParkingPlaceDTO obj)
        {
            ParkingPlace ParkingPlace = mapper.ParkingPlaceDTOToParkingPlace(obj);
            ParkingPlaceRepository.Create(ParkingPlace);
        }

        public void Delete(string name)
        {
            ParkingPlaceRepository.Delete(name);
        }

        public IEnumerable<ParkingPlaceDTO> GetAll()
        {
            List<ParkingPlaceDTO> ParkingPlaces = new List<ParkingPlaceDTO>();
            foreach (var i in ParkingPlaceRepository.GetAll())
            {
                ParkingPlaces.Add(mapper.ParkingPlaceToParkingPlaceDTO(i));
            }

            return ParkingPlaces;
        }

        public ParkingPlaceDTO Read()
        {
            throw new System.NotImplementedException();
        }

        public void Update(ParkingPlaceDTO obj)
        {
            throw new System.NotImplementedException();
        }
    }
}