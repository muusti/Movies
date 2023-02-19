using DataAccess.Contexts;
using DataAccess.Repositories.Bases;

namespace DataAccess.Repositories
{
    public class UserRepo : UserRepoBase
    {
        public UserRepo(MoviesContext dbContext) : base(dbContext)
        {
        }
    }
}
