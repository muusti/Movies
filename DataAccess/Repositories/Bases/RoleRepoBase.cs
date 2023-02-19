using AppCore.DataAccess.EntityFramework.Bases;
using DataAccess.Contexts;
using DataAccess.Entities;

namespace DataAccess.Repositories.Bases
{
    public abstract class RoleRepoBase : RepositoryPattern<Role>
    {
        protected RoleRepoBase(MoviesContext dbContext) : base(dbContext)
        {
        }
    }
}
