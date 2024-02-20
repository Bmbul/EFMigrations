using EFDbLayer.Models;

using Microsoft.EntityFrameworkCore;

namespace EFDbLayer.Entity
{
    public class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        //public DbSet<AuthorBook> AuthorBook { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>()
                .HasOne(x=>x.Author)
                .WithMany(x => x.Books)
                .HasForeignKey(x=>x.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);



            //Many to Many ---------------------------------
            //modelBuilder.Entity<Author>().HasKey(a => a.Id);

            //modelBuilder.Entity<Book>().HasKey(a => a.Id);
            //modelBuilder.Entity<AuthorBook>().HasKey(k => new { k.AuthorId, k.BookId });

            //modelBuilder.Entity<AuthorBook>()
            //            .HasOne(ab => ab.Author) 
            //            .WithMany(a => a.AuthorBooks) 
            //            .HasForeignKey(ab => ab.AuthorId); 

            //modelBuilder.Entity<AuthorBook>()
            //            .HasOne(ab => ab.Book) 
            //            .WithMany(b => b.AuthorBooks) 
            //            .HasForeignKey(ab => ab.BookId);



            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-I6JDFV5;Database=EfCoreTest;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
