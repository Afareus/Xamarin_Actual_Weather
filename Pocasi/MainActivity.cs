using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using Shared;
using Android.Graphics;

namespace Pocasi
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IWeatherView, ISunriseSunsetView
    {
        ImageView imageViewPicture;
        TextView textViewSunrise;
        TextView textViewSunset;
        TextView textViewCity;
        TextView textViewWeather;
        TextView textViewTemperature;
        TextView textViewWind;
        TextView textViewHumidity;
        TextView textViewLocalTime;
        Button buttonChange;
        WeatherService weatherService;                                    // třída z backendu (z projektu Shared)
        SunriseSunsetService sunriseSunsetService;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);                 // zavolá layout

            SetupReferences();
            SubscriveEventHandlers();



        }
        private void SetupReferences() {
            textViewSunrise = FindViewById<TextView>(Resource.Id.textViewSunrise);
            textViewSunset = FindViewById<TextView>(Resource.Id.textViewSunset);
            imageViewPicture = FindViewById<ImageView>(Resource.Id.imageViewPicture);
            textViewCity = FindViewById<TextView>(Resource.Id.textViewCity);
            textViewWeather = FindViewById<TextView>(Resource.Id.textViewWeather);
            textViewTemperature = FindViewById<TextView>(Resource.Id.textViewTemperature);
            textViewWind = FindViewById<TextView>(Resource.Id.textViewWind);
            textViewHumidity = FindViewById<TextView>(Resource.Id.textViewHumidity);
            textViewLocalTime = FindViewById<TextView>(Resource.Id.textViewLocalTime);
            buttonChange = FindViewById<Button>(Resource.Id.buttonChange);
            weatherService = new WeatherService(this);                             // třída z backendu (z projektu Shared)
            sunriseSunsetService = new SunriseSunsetService(this);
        }

        private void SubscriveEventHandlers() {
            buttonChange.Click += ButtonChange_Click;
        }

        private void ButtonChange_Click(object sender, EventArgs e) {
            Intent intent = new Intent(this, typeof(CitiesActivity));       // objekt který má v datové složky o aktivitě
            StartActivityForResult(intent, 1);                              // spuštění aktivity s requestCode 1 (sám si určím číslo)
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data) {
            if (requestCode == 1 && resultCode == Result.Ok) {
                string city = data.GetStringExtra("City");
                textViewCity.Text = city;
                weatherService.GetWeatherForCityAsync(city);
            }
        }

        private Bitmap GetImageBitmapFromUrl(string url) {
            Bitmap imageBitmap = null;
            using (var webClient = new System.Net.WebClient()) {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0) {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }
            return imageBitmap;
        }

        public void SetWeatherData(WeatherModel weatherModel) {
            textViewCity.Text = weatherModel.location.name;
            textViewWeather.Text = weatherModel.current.weather_descriptions[0];
            textViewHumidity.Text = weatherModel.current.humidity.ToString();
            textViewLocalTime.Text = weatherModel.location.localtime;
            textViewWind.Text = weatherModel.current.wind_speed.ToString() + " km/h " ;
            textViewTemperature.Text = weatherModel.current.temperature.ToString();
            imageViewPicture.SetImageBitmap(GetImageBitmapFromUrl(weatherModel.current.weather_icons[0]));

            sunriseSunsetService.GetSunriseSunsetInfoAsync(weatherModel.location.lat, weatherModel.location.lon);

        }

        public void SetSunriseSunsetData(SunriseSunsetModel sunsetModel) {
            textViewSunrise.Text = sunsetModel.results.sunrise;
            textViewSunset.Text = sunsetModel.results.sunset;

        }
    }
}