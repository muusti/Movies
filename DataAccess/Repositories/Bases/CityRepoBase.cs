using AppCore.DataAccess.EntityFramework.Bases;
using DataAccess.Contexts;
using DataAccess.Entities;

namespace DataAccess.Repositories.Bases
{
    public abstract class CityRepoBase : RepositoryPattern<City>
    {
        public CityRepoBase(MoviesContext dbContext) : base(dbContext)
        {
        }
    }
}
