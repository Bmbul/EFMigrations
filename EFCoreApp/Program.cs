using EFDbLayer;
using Microsoft.EntityFrameworkCore;

class Program
{

    static public void Main(String[] args)
    {
        using (var context = new AppDbContext())
        {

            var authors = context.Authors.Include(x => x.Book);

            var books = context.Books.Include(x => x.Author);

            var newBook = new Book() { Title = "Book Title" };
            
            context.Books.Add(newBook);
            context.SaveChanges();
        }
    }
}