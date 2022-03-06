using DT.Domain.General;
using DT.Domain.Interfaces;

namespace DT.Domain.Models
{
    public class AddWeatherForecastViewModel: IViewModel
    {
        public int TemperatureC { get; set; }

        public string? Summary { get; set; }
    }
}