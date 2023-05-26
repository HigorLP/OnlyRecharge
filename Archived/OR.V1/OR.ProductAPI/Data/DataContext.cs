using Microsoft.EntityFrameworkCore;
using OR.ProductAPI.Models;

namespace OR.ProductAPI.Data {
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            // Category

            modelBuilder.Entity<CategoryModel>().HasKey(c => c.CategoryId);

            modelBuilder.Entity<CategoryModel>()
                .Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();

            // Product

            modelBuilder.Entity<ProductModel>()
                .Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<ProductModel>()
                .Property(c => c.Description)
                .HasMaxLength(500)
                .IsRequired();

            modelBuilder.Entity<ProductModel>()
                .Property(c => c.Image)
                .HasMaxLength(255)
                .IsRequired();

            modelBuilder.Entity<ProductModel>()
                .Property(c => c.Price)
                .HasPrecision(12, 2);

            // Relationship

            modelBuilder.Entity<CategoryModel>()
                .HasMany(g => g.Products)
                .WithOne(c => c.Category)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
