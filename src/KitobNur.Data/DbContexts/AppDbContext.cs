using KitobNur.Domain.Entities.Books;
using KitobNur.Domain.Entities.Categories;
using KitobNur.Domain.Entities.Users;
using KitobNur.Domain.Library;
using KitobNur.Domain.Users;
using Microsoft.EntityFrameworkCore;
using KitobNur.Data.SeedDatas;
using KitobNur.Domain.Entities.Rentals; // Import the namespace containing SeedData

namespace KitobNur.Data.DbContexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<InitBook> InitBooks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<VistorLog> VistorLogs { get; set; }
        public DbSet<OrderBook> OrderBooks { get; set; }
        public DbSet<BestsellerBook> BestsellerBooks { get; set; }
        public DbSet<LibraryReadingHistory> LibraryReadingHistory { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host = localhost; Port=5432; Database = KitobNurDb; UserId=postgres; Password=123456@avbek;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Categories data
            modelBuilder.Entity<Category>().HasData(SeedData.GetCategories().ToArray());

            // Seed books data
            modelBuilder.Entity<Book>().HasData(SeedData.GetBooks().ToArray());
            // Other entity configurations...
        }
    }
}
