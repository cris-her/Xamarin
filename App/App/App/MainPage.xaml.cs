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
            //etiqueta.TextColor = Color.Blue;
            //var x = etiqueta.Width;
        }

        private void OnClick(object sender, EventArgs e)
        {
            //etiqueta.TextColor = Color.Blue;
            /*if((Color)etiqueta.GetValue(Label.TextColorProperty)== Color.Red)
            {
                etiqueta.SetValue(Label.TextColorProperty, Color.Blue);
            } else
            {
                etiqueta.SetValue(Label.TextColorProperty, Color.Red);
            }*/
            
        }

        private void OnClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            /*var column = (int)button.GetValue(Grid.ColumnProperty);
            if (column == 0)
            {
                button.SetValue(Grid.ColumnProperty, 1);
            } else
            {
                button.SetValue(Grid.ColumnProperty, 0);
            }*/

            if (Grid.GetColumn(button) == 0)
            {
                Grid.SetColumn(button, 1);
            } else
            {
                Grid.SetColumn(button, 0);
            }
        }
    }
}
