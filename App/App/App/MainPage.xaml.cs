using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<Page2>(this, "Hola", async (s) => 
            { 
                await DisplayAlert("Saludo", "Holaaa", "Ok"); 
            });
        }

        /*private void OnClicked(object sender, EventArgs e)
        {
            button1.ScaleTo(2, 2000, Easing.BounceOut);
        }*/

        private async void OnClick(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Page2());
            await Navigation.PushModalAsync(new Page2());
        }

        private async void OnClicked(object sender, EventArgs e)
        {
            /*var result = await DisplayActionSheet("Opciones", "Ok", null, new[] { "Colombia", "Mexico", "Costa Rica", "Peru" });

            await DisplayAlert("Saludo", "Hola " + result, "Aceptar");*/

            await Navigation.PushAsync(new Page2());
        }
    }
}
