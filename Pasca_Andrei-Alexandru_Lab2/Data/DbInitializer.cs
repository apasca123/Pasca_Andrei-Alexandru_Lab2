using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pasca_Andrei_Alexandru_Lab2.Models;

namespace Pasca_Andrei_Alexandru_Lab2.Data
{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryContext(serviceProvider.GetRequiredService<DbContextOptions<LibraryContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }

                //var authors = new Author[]
                //{
                //new Author { FirstName = "Mihail", LastName = "Sadoveanu" },
                //new Author { FirstName = "George", LastName = "Calinescu" },
                //new Author { FirstName = "Mircea", LastName = "Eliade" }
                //};
                //context.Authors.AddRange(authors);
                //context.SaveChanges();

                //var books = new Book[]{
                //    new Book { Title = "Baltagul", AuthorID = authors[0].ID, Price = Decimal.Parse("22") },
                //    new Book { Title = "Enigma Otiliei", AuthorID = authors[1].ID, Price = Decimal.Parse("18") },
                //    new Book { Title = "Maytrei", AuthorID = authors[2].ID, Price = Decimal.Parse("27") },
                //    new Book { Title = "Ion", AuthorID = authors[2].ID, Price = Decimal.Parse("27") },
                //    new Book { Title = "Salut", AuthorID = authors[0].ID, Price = Decimal.Parse("27") }
                //};

                //context.Books.AddRange(books);

                var books = context.Books.ToList();

                ////context.SaveChanges();

                ////context.Customers.AddRange(
                ////    new Customer { Name = "Popescu Marcela", Adress = "Str. Plopilor, nr. 24", BirthDate = DateTime.Parse("1979-09-01") },
                ////    new Customer { Name = "Mihailescu Cornel", Adress = "Str. Bucuresti, nr. 45, ap. 2", BirthDate = DateTime.Parse("1969-07-08") }
                ////    );

                //var customers = context.Customers.ToList();
                ////context.Customers.AddRange(customers);
                ////context.SaveChanges();

                //var orders = new Order[]{
                //    new Order{BookID=books[0].ID,CustomerID=customers[0].CustomerID,OrderDate=DateTime.Parse("2021-02-25") },
                //    new Order{BookID=books[1].ID,CustomerID=customers[0].CustomerID,OrderDate=DateTime.Parse("2021-09-28") },
                //    new Order{BookID=books[2].ID,CustomerID=customers[1].CustomerID,OrderDate=DateTime.Parse("2021-10-28") },
                //    new Order{BookID=books[3].ID,CustomerID=customers[0].CustomerID,OrderDate=DateTime.Parse("2021-09-28") },
                //    new Order{BookID=books[4].ID,CustomerID=customers[1].CustomerID,OrderDate=DateTime.Parse("2021-09-28") },
                //    new Order{BookID=books[0].ID,CustomerID=customers[1].CustomerID,OrderDate=DateTime.Parse("2021-10-28") }
                //};
                //foreach (Order e in orders)
                //{
                //    context.Orders.Add(e);
                //}
                //context.SaveChanges();

                //var publishers = new Publisher[]
                //{
                //    new Publisher{PublisherName="Humanitas",Adress="Str. Aviatorilor, nr. 40, Bucuresti"},
                //    new Publisher{
                //        PublisherName = "Nemira", Adress = "Str. Plopilor, nr. 35, Ploiesti"},
                //    new Publisher{PublisherName="Paralela 45",Adress="Str. Cascadelor, nr. 22, Cluj-Napoca"},
                //};
                //foreach (Publisher p in publishers)
                //{
                //    context.Publishers.Add(p);
                //}
                var publishers = context.Publishers.ToList();
                context.SaveChanges();
                var publishedbooks = new PublishedBook[]
                {
                    new PublishedBook {
                        BookID = books.Single(c => c.Title == "Maytrei" ).ID,
                        PublisherID = publishers.Single(i => i.PublisherName == "Humanitas").ID
                    },
                    new PublishedBook {
                        BookID = books.Single(c => c.Title == "Ion" ).ID,
                        PublisherID = publishers.Single(i => i.PublisherName == "Humanitas").ID
                    },
                    new PublishedBook {
                        BookID = books.Single(c => c.Title == "Baltagul" ).ID,
                        PublisherID = publishers.Single(i => i.PublisherName == "Nemira").ID
                    },
                    new PublishedBook {
                        BookID = books.Single(c => c.Title == "Salut" ).ID,
                        PublisherID = publishers.Single(i => i.PublisherName == "Paralela 45").ID
                    },
                    new PublishedBook {
                        BookID = books.Single(c => c.Title == "Enigma Otiliei" ).ID,
                        PublisherID = publishers.Single(i => i.PublisherName == "Paralela 45").ID
                    },
                    new PublishedBook {
                        BookID = books.Single(c => c.Title == "Maytrei" ).ID,
                        PublisherID = publishers.Single(i => i.PublisherName == "Paralela 45").ID
                    }
                };

                foreach (PublishedBook pb in publishedbooks)
                {
                    context.PublishedBooks.Add(pb);
                }
                context.SaveChanges();
            }
        }
    }
}