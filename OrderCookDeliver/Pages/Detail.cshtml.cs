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
            Name = "Quinoa Stuffed Peppers";
            Description = "Bell peppers are stuffed and baked with quinoa, vegetables, and tomato sauce. Top with bubbling mozzarella cheese for a hearty and flavorful meal... This vegetarian dish is so filling, and I love it because its incredibly versatile.";
            Qty = 1;
            Price = 5.99;
        }
        

    }
}