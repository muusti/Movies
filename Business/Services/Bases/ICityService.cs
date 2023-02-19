using AppCore.Business.Services.Bases;
using Business.Models;

namespace Business.Services.Bases
{
    public interface ICityService : IService<CityModel>
    {
        List<CityModel> GetList(int countryId);
        List<CityModel> GetList();
        CityModel GetItem(int id);

    }
}
