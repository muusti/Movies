using DataAccess.Contexts;
using DataAccess.Repositories.Bases;

namespace DataAccess.Repositories
{
    public class CharacterRepo : CharacterRepoBase
    {
        public CharacterRepo(MoviesContext dbContext) : base(dbContext)
        {
        }
    }
}
