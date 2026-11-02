using Microsoft.EntityFrameworkCore;
using OrderService.Modules.Orders;

namespace OrderService.Modules.Orders
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) { }

        // This line maps your database table!
        public DbSet<Order> Orders => Set<Order>();
    }
}
