using AppCore.DataAccess.EntityFramework.Bases;
using DataAccess.Contexts;
using DataAccess.Entities;

namespace DataAccess.Repositories.Bases
{
    public abstract class MovieRepoBase : RepositoryPattern<Movie>
    {
        protected MovieRepoBase(MoviesContext dbContext) : base(dbContext)
        {
        }
    }
}
