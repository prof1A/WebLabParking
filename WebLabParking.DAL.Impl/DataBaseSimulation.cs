using System;
using System.Collections.Generic;
using WebLabParking.Entities;

namespace WebLabParking.DAL.Impl
{
    public static class DataBaseSimulation
    {
        public static List<Car> cars = new List<Car>();
        public static List<Client> clients = new List<Client>();
        public static List<Parking> parkings = new List<Parking>();
        public static List<ParkingPlace> parkingsPlaces = new List<ParkingPlace>();
        public static List<ParkingTicket> parkingTickets = new List<ParkingTicket>();

        static DataBaseSimulation()
        {
            Car car1 = new Car{Name = "BMW X5"};
            Car car2 = new Car{Name = "Tesla Model S"};
            Car car3 = new Car{Name = "Tesla Model 3" };
            Car car4 = new Car{Name = "Tesla Model X" };
            Car car5 = new Car{Name = "Mercedes AMG GT"};
            Car car6 = new Car{Name = "Mercedes S class"};
            Car car7 = new Car{Name = "BMW M3"};

            car1.Tickets = new List<ParkingTicket>();
            car2.Tickets = new List<ParkingTicket>();
            car3.Tickets = new List<ParkingTicket>();
            car4.Tickets = new List<ParkingTicket>();
            car5.Tickets = new List<ParkingTicket>();
            car6.Tickets = new List<ParkingTicket>();
            car7.Tickets = new List<ParkingTicket>();
            

            Client client1 = new Client{Name="Tyler Durden"};
            Client client2 = new Client{Name="Thomas Anderson"};
            Client client3 = new Client{Name="Vincent Vega"};
            Client client4 = new Client{Name="Forrest Gump"};
            client1.Tickets = new List<ParkingTicket>();
            client2.Tickets = new List<ParkingTicket>();
            client3.Tickets = new List<ParkingTicket>();
            client4.Tickets = new List<ParkingTicket>();


            Parking parking1 = new Parking{ParkingName = "Parking ONE"};
            Parking parking2 = new Parking{ParkingName = "Parking TWO"};
            parking1.Places = new List<ParkingPlace>();
            parking1.Tickets = new List<ParkingTicket>();
            parking2.Places = new List<ParkingPlace>();
            parking2.Tickets = new List<ParkingTicket>();
            //not all

            ParkingPlace parkingPlace1 = new ParkingPlace{Number = 1};
            ParkingPlace parkingPlace2 = new ParkingPlace{Number = 2};
            ParkingPlace parkingPlace3 = new ParkingPlace{Number = 3};
            ParkingPlace parkingPlace4 = new ParkingPlace{Number = 4};
            ParkingPlace parkingPlace5 = new ParkingPlace{Number = 5};
            ParkingPlace parkingPlace6 = new ParkingPlace{Number = 6};
            ParkingPlace parkingPlace7 = new ParkingPlace{Number = 7};
            ParkingPlace parkingPlace8 = new ParkingPlace{Number = 8};
            ParkingPlace parkingPlace9 = new ParkingPlace{Number = 9};
            //not all
            cars.AddRange(new List<Car> { car1, car2, car3, car4, car5, car6, car7 });
            clients.AddRange(new List<Client> { client1, client2, client3, client4 });
            parkings.AddRange(new List<Parking> { parking1, parking2 });
            parkingsPlaces.AddRange(new List<ParkingPlace> { parkingPlace1, parkingPlace2, parkingPlace3, parkingPlace4, parkingPlace5, parkingPlace6, parkingPlace7, parkingPlace8, parkingPlace9 });
            ParkingTicket parkingTicket1 = new ParkingTicket{Car = cars[0], Client = clients[0], ParkingPlace = parkingsPlaces[0], LeavingTime = new DateTime(2020, 5, 10), TakingTime = new DateTime(2020, 5, 13)};
            ParkingTicket parkingTicket2 = new ParkingTicket{Car = cars[1], Client = clients[1], ParkingPlace = parkingsPlaces[1], LeavingTime = new DateTime(2020, 5, 10), TakingTime = new DateTime(2020, 5, 13)};
            ParkingTicket parkingTicket3 = new ParkingTicket{Car = cars[2], Client = clients[2], ParkingPlace = parkingsPlaces[2], LeavingTime = new DateTime(2020, 5, 10), TakingTime = new DateTime(2020, 5, 13)};
            ParkingTicket parkingTicket4 = new ParkingTicket{Car = cars[3], Client = clients[3], ParkingPlace = parkingsPlaces[3], LeavingTime = new DateTime(2020, 5, 10), TakingTime = new DateTime(2020, 5, 13)};
            ParkingTicket parkingTicket5 = new ParkingTicket{Car = cars[4], Client = clients[0], ParkingPlace = parkingsPlaces[4], LeavingTime = new DateTime(2020, 5, 10), TakingTime = new DateTime(2020, 5, 13)};
            ParkingTicket parkingTicket6 = new ParkingTicket{Car = cars[5], Client = clients[1], ParkingPlace = parkingsPlaces[5], LeavingTime = new DateTime(2020, 5, 10), TakingTime = new DateTime(2020, 5, 13)};
            ParkingTicket parkingTicket7 = new ParkingTicket{Car = cars[6], Client = clients[2], ParkingPlace = parkingsPlaces[6], LeavingTime = new DateTime(2020, 5, 10), TakingTime = new DateTime(2020, 5, 13)};
            parkingTickets.AddRange(new List<ParkingTicket> { parkingTicket1, parkingTicket2, parkingTicket3, parkingTicket4, parkingTicket5, parkingTicket6, parkingTicket7 });
            car1.Tickets.Add(parkingTickets[0]);
            car2.Tickets.Add(parkingTickets[1]);
            car3.Tickets.Add(parkingTickets[2]);
            car4.Tickets.Add(parkingTickets[3]);
            car5.Tickets.Add(parkingTickets[4]);
            car6.Tickets.Add(parkingTickets[5]);
            car7.Tickets.Add(parkingTickets[6]);

            client1.Tickets.Add(parkingTickets[0]);
            client1.Tickets.Add(parkingTickets[4]);
            client2.Tickets.Add(parkingTickets[1]);
            client2.Tickets.Add(parkingTickets[5]);
            client3.Tickets.Add(parkingTickets[2]);
            client3.Tickets.Add(parkingTickets[6]);
            client4.Tickets.Add(parkingTickets[3]);

            parking1.Places.AddRange(new List<ParkingPlace>{parkingsPlaces[0], parkingsPlaces[1], parkingsPlaces[2], parkingsPlaces[3] });
            parking1.Tickets.AddRange(new List<ParkingTicket> { parkingTickets[0], parkingTickets[1], parkingTickets[2], parkingTickets[3] });
            parking2.Places.AddRange(new List<ParkingPlace> { parkingsPlaces[4], parkingsPlaces[5], parkingsPlaces[6], parkingsPlaces[7], parkingsPlaces[8] });
            parking2.Tickets.AddRange(new List<ParkingTicket> {parkingTickets[4], parkingTickets[5], parkingTickets[6] });

            parkingPlace1.Ticket = parkingTickets[0];
            parkingPlace2.Ticket = parkingTickets[1];
            parkingPlace3.Ticket = parkingTickets[2];
            parkingPlace4.Ticket = parkingTickets[3];
            parkingPlace5.Ticket = parkingTickets[4];
            parkingPlace6.Ticket = parkingTickets[5];
            parkingPlace7.Ticket = parkingTickets[6];




 
           

        }
    }
}