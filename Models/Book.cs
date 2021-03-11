using System.ComponentModel.DataAnnotations;

//creating "book" class and every variable that is part of the book
namespace Assignment5.Models
{
    public class Book
    {
        //making BookId the primary key
        [Key] 
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public long ISBN { get; set; }
        public string Class { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public int Pages { get; set; }
    }
}
