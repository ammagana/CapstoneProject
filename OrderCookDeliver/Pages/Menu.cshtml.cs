using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrderCookDeliver.Data;
using OrderCookDeliver.Models;

namespace OrderCookDeliver.Pages
{
    public class MenuModel : PageModel
    {
        private readonly OrderCookDeliver.Data.OrderCookDeliverContext _context;
        public MenuModel(OrderCookDeliver.Data.OrderCookDeliverContext context)
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