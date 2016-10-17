using Labo5.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Labo5.DataAccessObject
{
    class WeatherService
    {
        public async Task<IEnumerable<WeatherForecast>> GetForecast(string cityName)
        {
            var wc = new HttpClient();
            var weather = await wc.GetStringAsync(new Uri("http://api.openweathermap.org/data/2.5/forecast?q="+cityName+",be&lang=fr&appid=a989296472b87f95ff2b44e3719968f9"));
            var rawWeather = JObject.Parse(weather);
            var forecast = rawWeather["list"].Children().Select(d => new WeatherForecast()
                {
                    Date = d["dt_txt"].Value<DateTime>(),
                    MinTemp = d["main"]["temp_min"].Value<double>() - 273.15,
                    MaxTemp = d["main"]["temp_max"].Value<double>() - 273.15,
                    WeatherDescription = d["weather"].First["description"].Value<String>(),
                    WindSpeed = d["wind"]["speed"].Value<double>()
                });
            return forecast;
        }
    }
}
