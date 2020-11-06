using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana3JavierPila
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrirVistaDos_Clicked(object sender, EventArgs e)
        {
            //Abrir vista dos
            string user = txtUser.Text;
            string pass = txtPass.Text;

            await Navigation.PushAsync(new Vista_doss(user, pass));
        }
    }
}
