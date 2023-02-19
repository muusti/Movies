using DataAccess.Contexts;
using DataAccess.Repositories.Bases;

namespace DataAccess.Repositories
{
    public class CityRepo : CityRepoBase
    {
        public CityRepo(MoviesContext dbContext) : base(dbContext)
        {
        }
    }
}
