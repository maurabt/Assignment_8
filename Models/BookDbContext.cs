using Microsoft.EntityFrameworkCore;

//setting database
namespace Assignment5.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext (DbContextOptions<BookDbContext> options) : base(options){}
        public DbSet<Book> Books { get; set; }
    }
}
