using AppCore.Results.Bases;
using Business.Models;
using Business.Services.Bases;
using DataAccess.Repositories.Bases;

namespace Business.Services
{
    public class CityService : ICityService
    {
        private readonly CityRepoBase _cityRepo;

        public CityService(CityRepoBase cityRepo)
        {
            _cityRepo = cityRepo;
        }

        public Result Add(CityModel model)
        {
            throw new NotImplementedException();
        }

        public Result Delete(CityModel model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _cityRepo.Dispose();
        }

        public CityModel GetItem(int id)
        {
            return Query().SingleOrDefault(c => c.Id == id);
        }

        public List<CityModel> GetList(int countryId)
        {
            return Query().Where(c=> c.CountryId == countryId).ToList();
        }

        public List<CityModel> GetList()
        {
            throw new NotImplementedException();
        }

        public IQueryable<CityModel> Query()
        {
            return _cityRepo.Query().OrderBy(c => c.Name).Select(c => new CityModel()
            {
                Name = c.Name,
                CountryId = c.CountryId
            });
        }
        
        public Result Update(CityModel model)
        {
            throw new NotImplementedException();
        }
    }
}
