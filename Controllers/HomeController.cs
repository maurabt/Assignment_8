using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Assignment5.Models.ViewModels;
using System.Linq;

namespace Assignment5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookRepository _repository;
        //5 items per page
        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, IBookRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //Controller accepts category and page requests
        public IActionResult Index(string category, int pageNum = 1)
        {
            return View(new BookListViewModel
            {
                Books = _repository.Books
                .Where(p => category == null || p.Type == category)
                .OrderBy(p => p.BookId)
                .Skip((pageNum - 1) * PageSize)
                .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = PageSize,
                    TotalNumItems = category == null ?_repository.Books.Count() :
                        _repository.Books.Where(x => x.Type == category).Count()
                },
                Type = category
            }); 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
