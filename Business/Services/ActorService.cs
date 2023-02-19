using AppCore.Results.Bases;
using Business.Models;
using Business.Services.Bases;
using DataAccess.Entities;
using DataAccess.Repositories.Bases;
using System.Reflection.Metadata.Ecma335;

namespace Business.Services
{
    public class ActorService : IActorService
    {
        private readonly ActorRepoBase _actorRepo;
        public ActorService(ActorRepoBase actorRepo)
        {
            _actorRepo = actorRepo;
        }

        public Result Add(ActorModel model)
        {
            var entity = new Actor()
            {
                Name = model.Name,
                DateOfBirth = model.DateOfBirth,
                Gender = model.Gender,
                Surname = model.Surname,
                CityId = model.CityId,
                CountryId = model.CountryId,
            };
            _actorRepo.Add(entity);

            return new SuccessResult("Add record successful");

        }

        public Result Delete(int id)
        {
            _actorRepo.Delete(id);
            return new SuccessResult("Deleted record successful");
        }

        public void Dispose()
        {
            _actorRepo.Dispose();
        }

        public IQueryable<ActorModel> Query()
        {
            IQueryable<ActorModel> query = _actorRepo.Query().Select(actor => new ActorModel()
            {
                Name = actor.Name,
                DateOfBirth = actor.DateOfBirth,
                Gender = actor.Gender,
                Surname = actor.Surname,
                CityId = actor.CityId,
                CountryId = actor.CountryId
            });

            return query;
        }

        public Result Update(ActorModel model)
        {
            var entity = new Actor()
            {
                Id = model.Id,
                Name = model.Name,
                DateOfBirth = model.DateOfBirth,
                Gender = model.Gender,
                Surname = model.Surname,
                CityId = model.CityId,
                CountryId = model.CountryId
            };

            _actorRepo.Update(entity);
            return new SuccessResult("Update record successful");
        }
    }
}
