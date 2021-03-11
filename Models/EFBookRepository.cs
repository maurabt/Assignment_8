using System.Linq;

namespace Assignment5.Models
{
    public class EFBookRepository :IBookRepository
    {
        private BookDbContext _context;
        //Constructor
        public EFBookRepository (BookDbContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
