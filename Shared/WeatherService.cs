using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Shared;

namespace Shared {
    public class WeatherService {
        const string API_KEY = "da223c0631c80400f3e7ed08a1a33fc9";
        public IWeatherView weatherView;

        public WeatherService(IWeatherView weatherView) {
            this.weatherView = weatherView;
        }

        public async Task GetWeatherForCityAsync(string city) {        // async - metody u http byvají běžně asynchronní
            var client = new HttpClient();
            var response = await client.GetAsync("http://api.weatherstack.com/current?access_key=" + API_KEY + "&query=" + city); // await - pro asynchronní metody
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync(); // obsah odpovědi - string
                WeatherModel weatherModel = JsonConvert.DeserializeObject<WeatherModel>(content);
                weatherView.SetWeatherData(weatherModel);
            }
        }
    }
}