using Livraria.Models;
using System.Data.Entity;
using MySql.Data.Entity;

namespace Livraria.Net.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BookStoreContext : DbContext
    {
        public BookStoreContext() : base("MYSQL")
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}