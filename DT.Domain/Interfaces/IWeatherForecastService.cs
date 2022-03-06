using DT.Domain.Models;

namespace DT.Domain.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecastViewModel> Get();
        WeatherForecastViewModel Get(Guid id);
        void Add(AddWeatherForecastViewModel model);
        void Update(IViewModel model);
        void Delete(IViewModel model);
    }
}
