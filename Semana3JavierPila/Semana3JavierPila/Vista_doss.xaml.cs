using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3JavierPila
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vista_doss : ContentPage
    {
        public Vista_doss(string user, string pass)
        {
            InitializeComponent();
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {

        }
    }
}