using AppCore.DataAccess.EntityFramework.Bases;
using DataAccess.Contexts;
using DataAccess.Entities;

namespace DataAccess.Repositories.Bases
{
    public abstract class UserRepoBase : RepositoryPattern<User>
    {
        protected UserRepoBase(MoviesContext dbContext) : base(dbContext)
        {
        }
    }
}
