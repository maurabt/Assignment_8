using System.Linq;

namespace Assignment5.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
