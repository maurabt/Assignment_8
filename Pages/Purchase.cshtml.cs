using System.Linq;
using Assignment5.Infrastructure;
using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment5.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookRepository repository;

        //constructor
        public PurchaseModel (IBookRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }
        //properties
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        //methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = ReturnUrl ?? "/";
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(p => p.BookId == bookId);

            //when the cart is null
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            //add book and quantity of 1
            Cart.AddItem(book, 1);

            //HttpContext.Session.SetJson("cart", Cart);
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long BookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(c1 => c1.Book.BookId == BookId).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
