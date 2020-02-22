using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForecastTest.Models
{
    public class ForecastData
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Temperature { get; set; }
        public string Summary { get; set; }

        [NotMapped]
        public int TemperatureF => 32 + (int)(Temperature / 0.5556);
    }
}
