using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages; 

namespace OrderCookDeliver.Pages
{
    public class DetailModel : PageModel
    {
        private readonly OrderCookDeliver.Data.OrderCookDeliverContext _context;
        public DetailModel(OrderCookDeliver.Data.OrderCookDeliverContext context)
        {
            _context = context;
        }
        public IList<OrderCookDeliver.Models.Calendar> calendar { get; set; }
        public async Task OnGetAsync()
        {
            calendar = await _context.Calendar.ToListAsync();
        }


    }
}