using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Labo5.DataAccessObject;
using Labo5.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Labo5.ViewModel
{
    public class MainViewModel :ViewModelBase
    {
        private ObservableCollection<WeatherForecast> _forecast = null;

        public ObservableCollection<WeatherForecast> Forecast
        {
            get { return _forecast; }

            set
            {
                if (_forecast == value)
                {
                    return;
                }
                _forecast = value;
                RaisePropertyChanged("Forecast");
            }
        }

        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                var forecast = new Forecast() { CityName = "Namur" };
                var weatherForecasts = new List<WeatherForecast>();
                for (int i = 0; i < 40; i++)
                {
                    weatherForecasts.Add(new WeatherForecast()
                    {
                        Date = DateTime.Now.AddDays(i),
                        MaxTemp = 5 + i / 2,
                        MinTemp = 0 + i / 2,
                        WeatherDescription = "Peu nuageux",
                        WindSpeed = i % 7
                    });
                }
                forecast.WeatherForecasts = weatherForecasts;
                Forecast = new ObservableCollection<WeatherForecast>(weatherForecasts);
            }
            /*else
            {
                InitializeAsync();
            }*/
        }

        public string _citySearch;
        public string CitySearch
        {
            get
            {
                var appData = Windows.Storage.ApplicationData.Current;
                var roamingSettings = appData.RoamingSettings;
                if (roamingSettings.Values.ContainsKey("CitySearch"))
                {
                    return _citySearch = roamingSettings.Values["CitySearch"].ToString();
                }
                return _citySearch;
            }
            set
            {
                _citySearch = value;
                var appData = Windows.Storage.ApplicationData.Current;
                var roamingSettings = appData.RoamingSettings;
                roamingSettings.Values["CitySearch"] = _citySearch;
                if (_citySearch != null)
                {
                    RaisePropertyChanged("CitySearch");
                }
            }
        }

        public ICommand _clickSearch;
        public ICommand ClickSearch
        {
            get
            {
                if (this._clickSearch == null)
                {
                    this._clickSearch = new RelayCommand(() => InitializeAsync(CitySearch));
                }
                return this._clickSearch;
            }
        }

        public async Task InitializeAsync(string cityName)
        {
            var service = new WeatherService();
            var forecast = await service.GetForecast(cityName);
            Forecast = new ObservableCollection<WeatherForecast>(forecast);
        }
    }
}
