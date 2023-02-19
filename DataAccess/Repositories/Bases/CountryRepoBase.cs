using AppCore.DataAccess.EntityFramework.Bases;
using DataAccess.Contexts;
using DataAccess.Entities;

namespace DataAccess.Repositories.Bases
{
    public abstract class CountryRepoBase : RepositoryPattern<Country>
    {
        protected CountryRepoBase(MoviesContext dbContext) : base(dbContext)
        {

        }
    }
}
