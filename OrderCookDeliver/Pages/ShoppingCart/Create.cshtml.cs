using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OrderCookDeliver.Data;
using OrderCookDeliver.Models;

namespace OrderCookDeliver.Pages.ShoppingCart
{
    public class CreateModel : PageModel
    {
        private readonly OrderCookDeliver.Data.OrderCookDeliverContext _context;

        public CreateModel(OrderCookDeliver.Data.OrderCookDeliverContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            
            return Page();
            
            
        }

        [BindProperty]
        public Cart Cart { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                
                return Page();
            }

            _context.Cart.Add(Cart);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
