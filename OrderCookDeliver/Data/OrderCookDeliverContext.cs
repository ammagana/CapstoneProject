using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderCookDeliver.Models;

namespace OrderCookDeliver.Data
{
    public class OrderCookDeliverContext : DbContext
    {
        public OrderCookDeliverContext (DbContextOptions<OrderCookDeliverContext> options)
            : base(options)
        {
        }

        public DbSet<OrderCookDeliver.Models.Cart> Cart { get; set; }

    }
}
