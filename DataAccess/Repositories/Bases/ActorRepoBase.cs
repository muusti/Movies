using AppCore.DataAccess.EntityFramework.Bases;
using DataAccess.Contexts;
using DataAccess.Entities;

namespace DataAccess.Repositories.Bases
{
    public abstract class ActorRepoBase : RepositoryPattern<Actor>
    {
        protected ActorRepoBase(MoviesContext dbContext) : base(dbContext)
        {

        }
    }
}
