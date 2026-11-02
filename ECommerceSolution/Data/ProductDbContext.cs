using Microsoft.EntityFrameworkCore;

namespace ProductService.Modules.Products;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }
    public DbSet<Product> Products => Set<Product>();
}
