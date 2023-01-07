using Dal.Entity;
using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class BookContextDb : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=localhost;database=BookHouseDb; TrustServerCertificate=true;Trusted_connection=True");
            }
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookCategory>().HasKey(x => new { x.BookId, x.CategoryId });


            base.OnModelCreating(modelBuilder);
        }
    }
}
