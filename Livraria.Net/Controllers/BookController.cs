using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Livraria.Models;

namespace Livraria.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BookController : ApiController
    {
        private Net.DAL.BookStoreContext context;

        public BookController()
        {
            context = new Net.DAL.BookStoreContext();
        }

        public IEnumerable<Book> Get()
        {
            return context.Books.ToList();
        }
        
     /*   public IEnumerable<Book> Get(Book book)
        {
            return context.Books.Where(e => e.Equals(book));
        }

        public Book Get(int id)
        {
            return context.Books.Find(id);
        } */
        
        public void Post([FromBody]Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
        }
        
        public void Put(int id, [FromBody]Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Book book = new Book { Id = id };
            context.Books.Attach(book);
            context.Books.Remove(book);
            context.SaveChanges();
        }
    }
}
