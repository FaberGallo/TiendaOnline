using Microsoft.EntityFrameworkCore;
using TiendaOnline.Web.Models;

namespace TiendaOnline.Web.Data
{
 

    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {
                
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }


        public DbSet<Department> Departments { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) 


        
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()

                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<Country>()

                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<Country>()
                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<Department>()
            .HasIndex(t => t.Name)
            .IsUnique();

            modelBuilder.Entity<Product>()
           .HasIndex(t => t.Name)
           .IsUnique();


        }


    }


}



