using System;
using System.Collections.Generic;
using System.Text;

namespace WebLabParking.Entities
{
    public class ClientCars
    {
        public Client Client { get; set; }
        public List<Car> Cars { get; set; }
    }
}
