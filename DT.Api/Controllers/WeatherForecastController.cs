using DT.Domain.Entities;
using DT.Domain.Interfaces;
using DT.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _service;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet] // (Name = "GetWeatherForecast")
        public IEnumerable<WeatherForecastViewModel> Get()
        {
            return _service.Get();
        }

        [HttpPost]
        public void Post(AddWeatherForecastViewModel model)
        {
            _service.Add(new AddWeatherForecastViewModel()
            {
                TemperatureC = model.TemperatureC,
                Summary = model.Summary
            });
        }
    }
}