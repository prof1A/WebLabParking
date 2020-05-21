using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebLabParking.BLL.Abstract;
using WebLabParking.DAL.Abstract;
using WebLabParking.Models;

namespace WebLabParking.Web.Controllers
{
    public class HomeController : Controller
    {
        public ICarService CarService;
        public IClientService ClientService;
        public IParkingPlaceService ParkingPlaceService;
        public IParkingTicketService ParkingTicketService;
        public IParkingService ParkingService;
        public IEnumerable<ParkingDTO> list;
        public HomeController(ICarService carService, IClientService clientService, IParkingTicketService parkingTicketService, IParkingPlaceService parkingPlaceService, IParkingService parkingService)
        {
            CarService = carService;
            ClientService = clientService;
            ParkingPlaceService = parkingPlaceService;
            ParkingTicketService = parkingTicketService;
            ParkingService = parkingService;
            list = ParkingService.GetAll();
        }

        public IActionResult GetParkings()
        {
            return View(ParkingService.GetAll());
        }
        [HttpPost]
        public IActionResult GetParkingPlaces(ParkingDTO parkingDTO)
        {
            return View(parkingDTO);
        }
        [HttpPost]
        public IActionResult GetParkingTicket(ParkingPlaceDTO parkingPlaceDTO)
        {
            return View(parkingPlaceDTO);
        }
        public IActionResult DeleteParking(string parkingName)
        {
            ParkingService.Delete(parkingName);
            return Redirect("GetParkings");
        }
        [HttpPost]
        public IActionResult ReserveTicket(DateTime leavingTime, DateTime takingTime)
        {
            ParkingTicketDTO parkingTicketDTO = new ParkingTicketDTO();
            parkingTicketDTO.LeavingTime = leavingTime;
            parkingTicketDTO.TakingTime = takingTime;
            ParkingTicketService.Create(parkingTicketDTO);
            return Redirect("GetParkings");
        }

        public IActionResult FindFreePlaceParking()
        {
            List<ParkingDTO> parkings = new List<ParkingDTO>();
            foreach (var i in ParkingService.GetAll())
            {
                foreach (var j in i.Places)
                {
                    if (j.Ticket.LeavingTime == new DateTime(1, 1, 1))
                    {
                        if(!parkings.Contains(i))
                        {
                            parkings.Add(i);
                        }
                    }
                }
            }

            return View("GetParkings", parkings);
        }

        public IActionResult FindParkingTicketParking(DateTime leavingDateTime)
        {
             return View("GetParkingTicket",ParkingPlaceService.GetAll().ToList().Find(x => x.Ticket.LeavingTime == leavingDateTime));
        }
        public IActionResult SearchClient(string name)
        {

            return View("GetClients", new List<ClientDTO> {ClientService.Read(name)});
        }
        public IActionResult DeleteClient(string name)
        {
            ClientService.Delete(name);
            return Redirect("GetClients");
        }
        public IActionResult DeletePlace(int number)
        {
            ParkingPlaceService.Delete(number.ToString());
            return Redirect("GetParkings");
        }
        public IActionResult GetClients()
        {
            return View(ClientService.GetAll());
        }

        public IActionResult SearchNearestParking()
        {
            return View();
        }
    }
}
