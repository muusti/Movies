using DataAccess.Contexts;
using DataAccess.Repositories.Bases;

namespace DataAccess.Repositories
{
    public class DirectorRepo : DirectorRepoBase
    {
        public DirectorRepo(MoviesContext dbContext) : base(dbContext)
        {
        }
    }
}
