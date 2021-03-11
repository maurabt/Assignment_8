using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Assignment5.Models;

//navigation menu 

namespace Assignment5.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookRepository repository;

        public NavigationMenuViewComponent(IBookRepository r)
        {
            repository = r;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Type)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
