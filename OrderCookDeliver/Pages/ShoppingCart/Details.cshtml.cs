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
    public class DetailsModel : PageModel
    {
        private readonly OrderCookDeliver.Data.OrderCookDeliverContext _context;

        public DetailsModel(OrderCookDeliver.Data.OrderCookDeliverContext context)
        {
            _context = context;
        }

        public Cart Cart { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cart = await _context.Cart.FirstOrDefaultAsync(m => m.ID == id);

            if (Cart == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
