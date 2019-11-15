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

        public IList<Cart> Cart { get;set; }

        public async Task OnGetAsync()
        {
            Cart = await _context.Cart.ToListAsync();
        }
    }
}
