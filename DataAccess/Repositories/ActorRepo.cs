using DataAccess.Contexts;
using DataAccess.Repositories.Bases;

namespace DataAccess.Repositories
{
    public class ActorRepo : ActorRepoBase
    {
        public ActorRepo(MoviesContext dbContext) : base(dbContext)
        {
        }
    }
}
