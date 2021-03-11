using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

//typed out all data in the database, including the variables that belong to them
namespace Assignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDbContext>();
            
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = 0451419439,
                        Class = "Fiction",
                        Type = "Classic",
                        Price = 9.95,
                        Pages = 1488
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = 0743270755,
                        Class = "Non-Fiction",
                        Type = "Biography",
                        Price = 14.58,
                        Pages = 944
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = 0553384611,
                        Class = "Non-Fiction",
                        Type = "Biography",
                        Price = 21.54,
                        Pages = 832
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        Publisher = "Random House",
                        ISBN = 0812981254,
                        Class = "Non-Fiction",
                        Type = "Biography",
                        Price = 11.61,
                        Pages = 864
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = 0812974492,
                        Class = "Non-Fiction",
                        Type = "Historical",
                        Price = 13.33,
                        Pages = 528
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = 0804171281,
                        Class = "Fiction",
                        Type = "Historical Fiction",
                        Price = 15.95,
                        Pages = 288
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = 1455586691,
                        Class = "Non-Fiction",
                        Type = "Self-Help",
                        Price = 14.99,
                        Pages = 304
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = 1455523023,
                        Class = "Non-Fiction",
                        Type = "Self-Help",
                        Price = 21.66,
                        Pages = 240
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = 1591847984,
                        Class = "Non-Fiction",
                        Type = "Business",
                        Price = 29.16,
                        Pages = 400
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = 0553393613,
                        Class = "Fiction",
                        Type = "Thrillers",
                        Price = 15.03,
                        Pages = 642
                    },
                    new Book
                    {
                        Title = "The Screaming Staircase",
                        Author = "Jonathan Stroud",
                        Publisher = "Doubleday Children's Books",
                        ISBN = 1423186922,
                        Class = "Fiction",
                        Type = "Thrillers",
                        Price = 8.99,
                        Pages = 416
                    },
                    new Book
                    {
                        Title = "Fly By Night",
                        Author = "Frances Hardinge",
                        Publisher = "HarperCollins Publishers",
                        ISBN = 80060876272,
                        Class = "Fiction",
                        Type = "Fantasy",
                        Price = 12.72,
                        Pages = 448
                    },
                    new Book
                    {
                        Title = "The Magician's Dream",
                        Author = "Shawn Thomas Odyssey",
                        Publisher = "Egmont USA",
                        ISBN = 81606845110,
                        Class = "Fiction",
                        Type = "Fantasy",
                        Price = 20.68,
                        Pages = 320
                    }
                );
                //saving the data into the database
                context.SaveChanges();
            }
        }
    }
}
