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
    public class DeleteModel : PageModel
    {
        private readonly OrderCookDeliver.Data.OrderCookDeliverContext _context;

        public DeleteModel(OrderCookDeliver.Data.OrderCookDeliverContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cart = await _context.Cart.FindAsync(id);

            if (Cart != null)
            {
                _context.Cart.Remove(Cart);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
