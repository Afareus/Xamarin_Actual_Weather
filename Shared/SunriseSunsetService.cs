using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Shared {
    public class SunriseSunsetService {

        // https://api.sunrise-sunset.org/json?lat=36.7201600&lng=-4.4203400

        public ISunriseSunsetView SunriseSunsetView;

        public SunriseSunsetService(ISunriseSunsetView sunriseSunsetView) {
            this.SunriseSunsetView = sunriseSunsetView;
        }

        public async void GetSunriseSunsetInfoAsync(string lat, string lon) {        // async - metody u http byvají běžně asynchronní
            var client = new HttpClient();
            var response = await client.GetAsync("https://api.sunrise-sunset.org/json?lat=" + lat + "&lng="+ lon); // await - pro asynchronní metody
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                SunriseSunsetModel SunriseSunsetModel = JsonConvert.DeserializeObject<SunriseSunsetModel>(content);
                SunriseSunsetView.SetSunriseSunsetData(SunriseSunsetModel);
            }
        }

    }
}
