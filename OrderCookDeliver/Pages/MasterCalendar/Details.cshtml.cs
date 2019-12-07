using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrderCookDeliver.Data;
using OrderCookDeliver.Models;

namespace OrderCookDeliver.Pages.MasterCalendar
{
    public class DetailsModel : PageModel
    {
        private readonly OrderCookDeliver.Data.OrderCookDeliverContext _context;

        public DetailsModel(OrderCookDeliver.Data.OrderCookDeliverContext context)
        {
            _context = context;
        }

        public Calendar Calendar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Calendar = await _context.Calendar.FirstOrDefaultAsync(m => m.ID == id);

            if (Calendar == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
