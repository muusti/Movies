using DataAccess.Contexts;
using DataAccess.Repositories.Bases;

namespace DataAccess.Repositories
{
    public class RoleRepo : RoleRepoBase
    {
        public RoleRepo(MoviesContext dbContext) : base(dbContext)
        {
        }
    }
}
