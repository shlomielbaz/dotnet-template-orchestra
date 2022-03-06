using Microsoft.EntityFrameworkCore;
using DT.Domain.Entities;

namespace DT.Data
{
    public class DataContext : DbContext
    {
        public DbSet<WeatherForecast>? WeatherForecasts { get; set; }
    }
}
