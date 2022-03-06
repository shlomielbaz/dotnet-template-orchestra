using DT.Domain.General;
using DT.Domain.Interfaces;

namespace DT.Domain.Models
{

    public class WeatherForecastViewModel : IViewModel
    {
        public string ID { get; set; }
        public string Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF { get; set; }

        public string? Summary { get; set; }
    }
}