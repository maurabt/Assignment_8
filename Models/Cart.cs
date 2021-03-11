using System.Collections.Generic;
using System.Linq;

//c sharp for the cart
namespace Assignment5.Models
{
    public class Cart
    {
        //list for cart items
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        //including book name and quantity in cart
        public virtual void AddItem(Book book, int qty)
        {
            CartLine line = Lines
                .Where(p => p.Book.BookId == book.BookId)
                .FirstOrDefault();
            //when book is not already in cart
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = qty
                });
            }
            //when book is in the cart, increase the quantity
            else
            {
                line.Quantity += qty;
            }
        }

        public virtual void RemoveLine(Book book) =>
            Lines.RemoveAll(x => x.Book.BookId == book.BookId);

        public virtual void Clear() => Lines.Clear();

        //calculation for total amount in cart
        public decimal ComputeTotalSum() => (decimal)Lines.Sum(e => e.Book.Price * e.Quantity);

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
