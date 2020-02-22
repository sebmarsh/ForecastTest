using ForecastTest.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ForecastTest.Services
{
    public class PersistentForecastService : IWeatherForecastService
    {
        private readonly ForecastContext _ctx;

        public PersistentForecastService(ForecastContext ctx)
        {
            _ctx = ctx;
        }

        public Task<ForecastData[]> GetForecastAsync()
        {
            return Task.FromResult(_ctx.Data.ToArray());
        }
    }
}
