using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pocasi {
    [Activity(Label = "CitiesActivity")]
    public class CitiesActivity : Activity {
        TextView textViewOstrava;
        TextView textViewBruntal;
        TextView textViewHelsinky;
        TextView textViewRome;
        TextView textViewOttawa;


        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.cities_layout);

            SetupReferences();
            SubscriveEventHandlers();

        }

        private void SetupReferences() {
            textViewOstrava = FindViewById<TextView>(Resource.Id.textViewOstrava);
            textViewBruntal = FindViewById<TextView>(Resource.Id.textViewBruntal);
            textViewHelsinky = FindViewById<TextView>(Resource.Id.textViewHelsinky);
            textViewRome = FindViewById<TextView>(Resource.Id.textViewRome);
            textViewOttawa = FindViewById<TextView>(Resource.Id.textViewOttawa);
        }

        private void SubscriveEventHandlers() {
            textViewBruntal.Click += TextViewBruntal_Click;
            textViewOstrava.Click += TextViewOstrava_Click;
            textViewHelsinky.Click += TextViewHelsinky_Click;
            textViewRome.Click += TextViewRome_Click;
            textViewOttawa.Click += TextViewOttawa_Click;
        }

        private void TextViewOttawa_Click(object sender, EventArgs e) {
            GoBackWithCity("Ottawa");
        }

        private void TextViewRome_Click(object sender, EventArgs e) {
            GoBackWithCity("Rome");
        }

        private void TextViewHelsinky_Click(object sender, EventArgs e) {
            GoBackWithCity("Helsinky");
        }

        private void TextViewOstrava_Click(object sender, EventArgs e) {
            GoBackWithCity("Ostrava");
        }

        private void TextViewBruntal_Click(object sender, EventArgs e) {
            GoBackWithCity("Bruntal");
        }

        private void GoBackWithCity(string city) {
            Intent intent = new Intent();
            intent.PutExtra("City", city);     // do Extra se uloží pod klíčem City Ottawa
            SetResult(Result.Ok, intent);          // nastaví ok
            Finish();                              // ukončí aktivitu
        }
    }
}