using System.Data.Entity;

namespace PH.BookStores.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=ApplicationDbContext")
        {

        }
    }
}
