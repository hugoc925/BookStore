using MBooks.Models;
using Microsoft.EntityFrameworkCore;

namespace MBooks
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }
        public DbSet<Book> book { get; set; }
    public DbSet<User> user { get; set; }

      
    }
}
    

