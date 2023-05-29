using Microsoft.EntityFrameworkCore;
using OR.Domain.Models;

namespace OR.Infrastructure.Data; 
public class ORContext : DbContext {
    public ORContext(DbContextOptions<ORContext> options) : base(options) {
    }

    public DbSet<ProductModel> Products { get; set; }
    public DbSet<CategoryModel> Categories { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder) {

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ORContext).Assembly);
    }
}
