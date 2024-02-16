using Microsoft.EntityFrameworkCore;

namespace EFDbLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                       .HasOne(a => a.Book)
                       .WithOne(x => x.Author)
                       .HasForeignKey<Book>(x => x.AuthorId);

            modelBuilder.Entity<Book>()
                       .HasOne(a => a.Author)
                       .WithOne(x => x.Book)
                       .HasForeignKey<Author>(x => x.BookId);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EfCoreTest;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
