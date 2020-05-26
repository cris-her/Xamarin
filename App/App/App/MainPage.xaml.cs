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
        }

        /*private void OnClicked(object sender, EventArgs e)
        {
            //var disco1 = Resources["disco1"] as Disco;
            //disco1.Titulo = "Revolver";

            var disco1 = Resources["datos1"] as Datos;
            datos1.Discos.Add(new Disco() { Banda = "Nirvana", Titulo = "Nevermind" });

        }*/
    }
}
