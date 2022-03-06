using DT.Data;
using DT.Domain.Entities;
using DT.Domain.Interfaces;
using DT.Domain.Models;

namespace DT.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private static readonly string[] Summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
        private readonly IRepository<DataContext> _db;
        private static List<WeatherForecast> _store = new List<WeatherForecast>();

        public WeatherForecastService(IRepository<DataContext> db)
        {
            _db = db;

            if (_store.Count == 0)
            {
                _store.AddRange(Enumerable.Range(1, 5)
                .Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                    ID = Guid.NewGuid()
                }).ToList());
            }
        }

        public void Add(AddWeatherForecastViewModel model)
        {
            // Get the AddWeatherForecastViewModel and convert it to Entity WeatherForecast
            _store.Add(new WeatherForecast()
            {
                Date = DateTime.Now,
                TemperatureC = model.TemperatureC,
                Summary = model.Summary,
                ID = Guid.NewGuid()
            });
        }

        public IEnumerable<WeatherForecastViewModel> Get()
        {
            return _store.Select(item => new WeatherForecastViewModel()
            {
                Date = item.Date.ToString("dd/MM/yyyy HH:mm:ss"),
                TemperatureC = item.TemperatureC,
                Summary = item.Summary,
                TemperatureF = item.TemperatureF,
                ID = item.ID.ToString()
            }).AsEnumerable();
        }

        public void Delete(IViewModel model)
        {
            throw new NotImplementedException();
        }

        public WeatherForecastViewModel Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(IViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
