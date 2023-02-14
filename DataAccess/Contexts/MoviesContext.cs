using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts
{
    public class MoviesContext : DbContext
    {



        public MoviesContext(DbContextOptions options) : base(options)
        {

        }
    }
}
