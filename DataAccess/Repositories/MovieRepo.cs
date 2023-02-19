using DataAccess.Contexts;
using DataAccess.Repositories.Bases;

namespace DataAccess.Repositories
{
    public class MovieRepo : MovieRepoBase
    {
        public MovieRepo(MoviesContext dbContext) : base(dbContext)
        {
        }
    }
}
