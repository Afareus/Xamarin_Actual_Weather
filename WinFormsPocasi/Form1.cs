using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;

namespace WinFormsPocasi {
    public partial class Form1 : Form , IWeatherView  {

        WeatherService weatherService;
        public Form1() {
            InitializeComponent();
            weatherService = new WeatherService(this);
        }

        public void SetWeatherData(WeatherModel weatherModel) {
            lblCity.Text = weatherModel.location.name;
            lblTemperature.Text = "Temperature: " + weatherModel.current.temperature.ToString();
            lblWeather.Text = "Wind: " + weatherModel.current.wind_speed.ToString() + " km/h";
            lblHumidity.Text = "Humidity: " + weatherModel.current.humidity.ToString() + "%";
        }

        private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e) {
            string city = comboBoxCities.SelectedItem.ToString();
            weatherService.GetWeatherForCityAsync(city);

        }
    }
}
