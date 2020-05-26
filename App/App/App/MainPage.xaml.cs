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
            //boton.Clicked += OnClicked;
            boton.Clicked += ( s, a ) => etiqueta.Text = "Hola " + DateTime.Now.ToString();
        }

        private void OnClicked(object sender, EventArgs e)
        {
            //var x = new Button();
            //etiqueta.Text = "Hola " + DateTime.Now.ToString();
        }
    }
}
