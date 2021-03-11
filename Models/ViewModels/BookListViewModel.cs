using System.Collections.Generic;

//gather books to display, page info (like page number, items per page), and book type (category)
namespace Assignment5.Models.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string Type { get; set; }
    }
}
