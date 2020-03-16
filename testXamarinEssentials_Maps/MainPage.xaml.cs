using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace testXamarinEssentials_Maps
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnOpenMaps.Clicked += BtnOpenMaps_Clicked;
        }

        private void BtnOpenMaps_Clicked(object sender, EventArgs e)
        {
            Location locaton = new Location(
                Convert.ToDouble(entryLatitude.Text),
                Convert.ToDouble(entryLongitude.Text)
                );

            var options = new MapLaunchOptions() {
            Name = "Satinder Sidhu Home Office"
            };

            Map.OpenAsync(locaton, options); 
        }
    }
}
