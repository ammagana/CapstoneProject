using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OrderCookDeliver.Pages
{
    public class DetailModel : PageModel
    {
        public int MealID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public int ServingSize { get; set; }
        public string Ingredients { get; set; }
        public string NutrientFacts { get; set; }
        public int Qty { get; set; }
        public void OnGet()
        {
            ImageURL = "noodles.jpg";
            Name = "Crispy Fried Chicken";
            Description = " Forget Noodles with buck choy and edamame, fried chicken is what's up. It's thinner than skin-on, bone-in fried chicken, which means the ratio of breading to meat is higher. In other words, it's crispy AF";
            Qty = 1;
            Price = 5.99;
        }
        

    }
}