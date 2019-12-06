using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrderCookDeliver.Data;
using OrderCookDeliver.Models;



namespace OrderCookDeliver.Pages.ShoppingCart
{

    public class IndexModel : PageModel
    {
        private readonly OrderCookDeliver.Data.OrderCookDeliverContext _context;

        public IndexModel(OrderCookDeliver.Data.OrderCookDeliverContext context)
        {
            _context = context;
        }

        public IList<Cart> Cart { get; set; }

        public async Task OnGetAsync()
        {
            Cart = await _context.Cart.ToListAsync();
        }
        public async Task<RedirectResult> OnPost()
        {
            Cart = await _context.Cart.ToListAsync();
            int x = 0;
            foreach (var item in Cart)
            {
                x = x + 1;
            }
            for(int i = 0; i < x; i++)
            {
                _context.Cart.Remove(Cart[i]);
            }
            
            await _context.SaveChangesAsync();
            var mealInfo = Request.Form["ordered"] +", "+ Request.Form["qtyOrder"] + ", " + Request.Form["pickupLocation"] + ", " + Request.Form["pickupTime"] + ", " + Request.Form["pickupDay"] + "\n";
            System.IO.File.AppendAllText("./Pages/Shared/OrderedMeals.txt", mealInfo);
            
            return Redirect("../Index");   
        }

    }   
}
