

using EFDbLayer;
using Microsoft.EntityFrameworkCore;
using System;

class Program
{

    static public void Main(String[] args)
    {
        using (var context = new AppDbContext())
        {

            var authors = context.Authors.Include(x => x.Book);

            var books = context.Books.Include(x => x.Author);
        }
    }
}