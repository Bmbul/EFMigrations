using Microsoft.EntityFrameworkCore;

namespace EFDbLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                       .HasOne(a => a.Author)
                       .WithMany(x => x.Books);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EfCoreTest;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
