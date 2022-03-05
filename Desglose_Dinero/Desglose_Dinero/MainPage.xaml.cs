using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Desglose_Dinero
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Qles_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Result()); //Nos dirige a la siguiente pagina 
        }

        private async void Dolar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Resutl_Dl()); //Nos dirige a la siguiente pagina Para calculo en dolares
        }
    }
}
