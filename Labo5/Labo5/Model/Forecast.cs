using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5.Model
{
    class Forecast
    {
        public String CityName
        {
            get; set;
        }

        public IEnumerable<WeatherForecast> WeatherForecasts
        {
            get; set;
        }
    }
}
