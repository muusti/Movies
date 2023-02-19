using DataAccess.Contexts;
using DataAccess.Repositories.Bases;

namespace DataAccess.Repositories
{
    public class CountryRepo : CountryRepoBase
    {
        public CountryRepo(MoviesContext dbContext) : base(dbContext)
        {
        }
    }
}
