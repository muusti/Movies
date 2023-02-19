using AppCore.DataAccess.EntityFramework.Bases;
using DataAccess.Contexts;
using DataAccess.Entities;

namespace DataAccess.Repositories.Bases
{
    public abstract class CharacterRepoBase : RepositoryPattern<Character>
    {
        protected CharacterRepoBase(MoviesContext dbContext) : base(dbContext)
        {
        }
    }
}
