using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderCookDeliver.Models
{
    public class Cart
    {
        public int ID { get; set; }

        public string Meal { get; set; }

        public decimal Price { get; set; }

        public int Serving { get; set; }

        public string PickupDay { get; set; }
    }
}
