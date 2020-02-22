using ForecastTest.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ForecastTest.Models
{
    public class ForecastContext : DbContext
    {
        public DbSet<ForecastData> Data { get; set; }

        public ForecastContext(DbContextOptions<ForecastContext> options) : base(options)
        {
            Database.EnsureCreated();

            if (Data.Count() == 0)
            {
                SeedDatabase();
            }
        }

        private void SeedDatabase()
        {
            for (var i = 1; i <= 15; i++)
            {
                var rnd = new Random();
                var t = rnd.Next(0, 35);
                var summary = string.Empty;

                if (t < 15)
                    summary = "Cool";
                else if (t < 25)
                    summary = "Warm";
                else
                    summary = "Hot";

                Data.Add(new ForecastData()
                {
                    Date = DateTime.Now.AddDays(i),
                    Temperature = t,
                    Summary = summary
                });
            }

            SaveChanges();
        }
    }
}
