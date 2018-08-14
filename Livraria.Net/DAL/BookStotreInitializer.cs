using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Livraria.Models;

namespace Livraria.Net.DAL
{
    public class BookStotreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BookStoreContext>
    {
        protected override void Seed(BookStoreContext context)
        {
            var books = new List<Book>
            {
                new Book{Name="A volta dos que não foram"}
            };

            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();

        }
    }
}