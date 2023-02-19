using AppCore.DataAccess.EntityFramework.Bases;
using DataAccess.Contexts;
using DataAccess.Entities;

namespace DataAccess.Repositories.Bases
{
    public abstract class DirectorRepoBase : RepositoryPattern<Director>
    {
        protected DirectorRepoBase(MoviesContext dbContext) : base(dbContext)
        {
        }
    }
}
