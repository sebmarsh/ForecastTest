using ForecastTest.Models;
using System.Threading.Tasks;

namespace ForecastTest.Services
{
    public interface IWeatherForecastService
    {
        public Task<ForecastData[]> GetForecastAsync();
    }
}
