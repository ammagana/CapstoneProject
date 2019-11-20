using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderCookDeliver.Models
{
    public class masterCalendar
    {
        public int ID { get; set; }

        public string mealId { get; set; }

        public string mealName { get; set; }

        public string description { get; set; }
        public int preparationTime { get; set; }
        public double pricePerServg { get; set; }
        public string ingredient_1 { get; set; }
        public string ingredient_2{ get; set; }
        public string ingredient_3 { get; set; }
        public string ingredient_4 { get; set; }
        public string ingredient_5 { get; set; }
        public string ingredient_6 { get; set; }
        public string ingredient_7 { get; set; }
        public string ingredient_8 { get; set; }
        public string ingredient_9 { get; set; }
        public string ingredient_10 { get; set; }
        public string ingredient_11 { get; set; }
        public string ingredient_12 { get; set; }
        public string ingredient_13 { get; set; }
        public string ingredient_14 { get; set; }
        public string ingredient_15 { get; set; }
        public string ingredient_16 { get; set; }
        public string ingredient_17 { get; set; }
        public double calPerServg { get; set; }
        public double totalFat { get; set; }
        public double saturatedFat { get; set; }
        public double transFat { get; set; }
        public double monoUnsatFat { get; set; }
        public double polyUnsatFat { get; set; }
        public double omega_3 { get; set; }
        public double omega_6 { get; set; }
        public double cholesterol { get; set; }
        public double totalCarb { get; set; }
        public double dietaryFiber { get; set; }
        public double sugar { get; set; }
        public double protein { get; set; }
        public string procedure { get; set; }

    }
}