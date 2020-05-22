using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebLabParking.Entities;

namespace WebLabParking.DAL.Impl
{
    public class DbInitializer
    {
        public static void Initialize(ParkingContext parkingContext)
        {
            ParkingContext context = parkingContext;

            List<Car> cars = new List<Car>();
            List<Client> clients = new List<Client>();
            List<Parking> parkings = new List<Parking>();
            List<ParkingPlace> parkingsPlaces = new List<ParkingPlace>();
            List<ParkingTicket> parkingTickets = new List<ParkingTicket>();

            Car car1 = new Car {Name = "BMW X5", 
                //id = 1

            };
            Car car2 = new Car {Name = "Tesla Model S",
                //id=2

            };
            Car car3 = new Car {Name = "Tesla Model 3",
                //id=3

            };
            Car car4 = new Car {Name = "Tesla Model X",
                //id = 4

            };
            Car car5 = new Car {Name = "Mercedes AMG GT", 
                //id=5

            };
            Car car6 = new Car {Name = "Mercedes S class",
                //id = 6
                };
            Car car7 = new Car
            {
                Name = "BMW M3",
                //id = 7

            };

            car1.Tickets = new List<ParkingTicket>();
            car2.Tickets = new List<ParkingTicket>();
            car3.Tickets = new List<ParkingTicket>();
            car4.Tickets = new List<ParkingTicket>();
            car5.Tickets = new List<ParkingTicket>();
            car6.Tickets = new List<ParkingTicket>();
            car7.Tickets = new List<ParkingTicket>();


            Client client1 = new Client {Name = "Tyler Durden", 
                //id = 1

            };
            Client client2 = new Client {Name = "Thomas Anderson", //id = 2
                                                                   };
            Client client3 = new Client {Name = "Vincent Vega",
                //id = 3

            };
            Client client4 = new Client {Name = "Forrest Gump",
                //id = 4

            };
            //client1.Tickets = new List<ParkingTicket>();
            //client2.Tickets = new List<ParkingTicket>();
            //client3.Tickets = new List<ParkingTicket>();
            //client4.Tickets = new List<ParkingTicket>();


            Parking parking1 = new Parking {ParkingName = "Parking ONE",
                //id = 1

            };
            Parking parking2 = new Parking {ParkingName = "Parking TWO",
                //id = 2

            };
            parking1.Places = new List<ParkingPlace>();
            parking1.Tickets = new List<ParkingTicket>();
            parking2.Places = new List<ParkingPlace>();
            parking2.Tickets = new List<ParkingTicket>();
            //not all

            ParkingPlace parkingPlace1 = new ParkingPlace {Number = 33,
                //id = 1

            };
            ParkingPlace parkingPlace2 = new ParkingPlace {Number = 12,
               // id = 2

            };
            ParkingPlace parkingPlace3 = new ParkingPlace {Number = 43,
                //id = 3

            };
            ParkingPlace parkingPlace4 = new ParkingPlace {Number = 11,
               // id = 4

            };
            ParkingPlace parkingPlace5 = new ParkingPlace {Number = 54,
               // id = 5

            };
            ParkingPlace parkingPlace6 = new ParkingPlace {Number = 32,
               // id = 6

            };
            ParkingPlace parkingPlace7 = new ParkingPlace {Number = 27,
               // id = 7

            };
            ParkingPlace parkingPlace8 = new ParkingPlace {Number = 50,
               // id = 8

            };
            ParkingPlace parkingPlace9 = new ParkingPlace {Number = 15,
                //id = 9
            };

            //not all
            cars.AddRange(new List<Car>
            {
                car1, car2, car3, car4, car5, car6, car7
            });
            clients.AddRange(new List<Client>
            {
                client1, client2, client3, client4
            });
            parkings.AddRange(new List<Parking>
            {
                parking1, parking2
            });
            parkingsPlaces.AddRange(new List<ParkingPlace>
            {
                parkingPlace1, parkingPlace2, parkingPlace3, parkingPlace4, parkingPlace5, parkingPlace6, parkingPlace7,
                parkingPlace8, parkingPlace9
            });

            ParkingTicket parkingTicket1 = new ParkingTicket
            {
                LeavingTime = new DateTime(2020, 5, 10), TakingTime = new DateTime(2020, 5, 13),
                //id = 1
            };

            ParkingTicket parkingTicket2 = new ParkingTicket
            {
                LeavingTime = new DateTime(2020, 5, 10), TakingTime = new DateTime(2020, 5, 13),
                //id = 2
            };

            ParkingTicket parkingTicket3 = new ParkingTicket
            {
                LeavingTime = new DateTime(2020, 5, 10), TakingTime = new DateTime(2020, 5, 13),
               //id = 3
            };

            ParkingTicket parkingTicket4 = new ParkingTicket
            {
                LeavingTime = new DateTime(2020, 5, 10), TakingTime = new DateTime(2020, 5, 13),
                //id = 4
            };

            ParkingTicket parkingTicket5 = new ParkingTicket
            {
                LeavingTime = new DateTime(2020, 5, 10), TakingTime = new DateTime(2020, 5, 13),
               // id = 5
            };

            ParkingTicket parkingTicket6 = new ParkingTicket
            {
                LeavingTime = new DateTime(2020, 5, 10), TakingTime = new DateTime(2020, 5, 13),
                //id = 6
            };

            ParkingTicket parkingTicket7 = new ParkingTicket
            {
                LeavingTime = new DateTime(2020, 5, 10), TakingTime = new DateTime(2020, 5, 13),
                //id = 7
            };












            //ParkingTicket parkingTicket1 = new ParkingTicket
            //{
            //    Car = cars[0],
            //    Client = clients[0],
            //    ParkingPlace = parkingsPlaces[0],
            //    LeavingTime = new DateTime(2020, 5, 10),
            //    TakingTime = new DateTime(2020, 5, 13),
            //    id = 1
            //};

            //ParkingTicket parkingTicket2 = new ParkingTicket
            //{
            //    Car = cars[1],
            //    Client = clients[1],
            //    ParkingPlace = parkingsPlaces[1],
            //    LeavingTime = new DateTime(2020, 5, 10),
            //    TakingTime = new DateTime(2020, 5, 13),
            //    id = 2
            //};

            //ParkingTicket parkingTicket3 = new ParkingTicket
            //{
            //    Car = cars[2],
            //    Client = clients[2],
            //    ParkingPlace = parkingsPlaces[2],
            //    LeavingTime = new DateTime(2020, 5, 10),
            //    TakingTime = new DateTime(2020, 5, 13),
            //    id = 3
            //};

            //ParkingTicket parkingTicket4 = new ParkingTicket
            //{
            //    Car = cars[3],
            //    Client = clients[3],
            //    ParkingPlace = parkingsPlaces[3],
            //    LeavingTime = new DateTime(2020, 5, 10),
            //    TakingTime = new DateTime(2020, 5, 13),
            //    id = 4
            //};

            //ParkingTicket parkingTicket5 = new ParkingTicket
            //{
            //    Car = cars[4],
            //    Client = clients[0],
            //    ParkingPlace = parkingsPlaces[4],
            //    LeavingTime = new DateTime(2020, 5, 10),
            //    TakingTime = new DateTime(2020, 5, 13),
            //    id = 5
            //};

            //ParkingTicket parkingTicket6 = new ParkingTicket
            //{
            //    Car = cars[5],
            //    Client = clients[1],
            //    ParkingPlace = parkingsPlaces[5],
            //    LeavingTime = new DateTime(2020, 5, 10),
            //    TakingTime = new DateTime(2020, 5, 13),
            //    id = 6
            //};

            //ParkingTicket parkingTicket7 = new ParkingTicket
            //{
            //    Car = cars[6],
            //    Client = clients[2],
            //    ParkingPlace = parkingsPlaces[6],
            //    LeavingTime = new DateTime(2020, 5, 10),
            //    TakingTime = new DateTime(2020, 5, 13),
            //    id = 7
            //};

            parkingTickets.AddRange(new List<ParkingTicket>
            {
                parkingTicket1, parkingTicket2, parkingTicket3, parkingTicket4, parkingTicket5, parkingTicket6,
                parkingTicket7
            });
            car1.Tickets.Add(parkingTickets[0]);
            car2.Tickets.Add(parkingTickets[1]);
            car3.Tickets.Add(parkingTickets[2]);
            car4.Tickets.Add(parkingTickets[3]);
            car5.Tickets.Add(parkingTickets[4]);
            car6.Tickets.Add(parkingTickets[5]);
            car7.Tickets.Add(parkingTickets[6]);

            client1.Ticket = parkingTickets[0];
            client2.Ticket = parkingTickets[1];
            client3.Ticket = parkingTickets[1];
            client4.Ticket = parkingTickets[1];
           

            parking1.Places.AddRange(new List<ParkingPlace>
            {
                parkingsPlaces[0], parkingsPlaces[1], parkingsPlaces[2], parkingsPlaces[3]
            });
            parking1.Tickets.AddRange(new List<ParkingTicket>
            {
                parkingTickets[0], parkingTickets[1], parkingTickets[2], parkingTickets[3]
            });
            parking2.Places.AddRange(new List<ParkingPlace>
            {
                parkingsPlaces[4], parkingsPlaces[5], parkingsPlaces[6], parkingsPlaces[7], parkingsPlaces[8]
            });
            parking2.Tickets.AddRange(new List<ParkingTicket>
            {
                parkingTickets[4], parkingTickets[5], parkingTickets[6]
            });

            parkingPlace1.Ticket = parkingTickets[0];
            parkingPlace2.Ticket = parkingTickets[1];
            parkingPlace3.Ticket = parkingTickets[2];
            parkingPlace4.Ticket = parkingTickets[3];
            parkingPlace5.Ticket = parkingTickets[4];
            parkingPlace6.Ticket = parkingTickets[5];
            parkingPlace7.Ticket = parkingTickets[6];

            foreach (var i in cars)
            {
                context.Cars.Add(i);
            }
            //if (context.Cars.Count()-1 > cars.Count)
            //{
            //    var i = context.Cars.Count();
            //    return;   // DB has been seeded
            //}
            context.SaveChanges();

            foreach (var i in clients)
            {
                context.Clients.Add(i);
            }

            context.SaveChanges();

            foreach (var i in parkings)
            {
                context.Parkings.Add(i);
            }

            context.SaveChanges();

            foreach (var i in parkingsPlaces)
            {
                context.ParkingPlaces.Add(i);
            }
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT parkingdb.dbo.ParkingPlaces ON;");
            context.SaveChanges();
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT MyDB.Users OFF");
            

            foreach (var i in parkingTickets)
            {
                context.ParkingTickets.Add(i);
            }

            context.SaveChanges();
        }
    }
}