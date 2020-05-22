using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebLabParking.Entities
{
    public class ClientCars
    {
        [Key]
        public int id { get; set; }
        public Client Client { get; set; }
        public List<Car> Cars { get; set; }
    }
}
