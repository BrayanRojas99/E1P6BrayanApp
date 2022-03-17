using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace E1P6BrayanApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivoRegisterPage : ContentPage
    {
        public ActivoRegisterPage()
        {
            InitializeComponent();
        }

        private async void cmdRegresar(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void cmdGuardar(object sender, EventArgs e)
        {
            await DisplayAlert("Success", "The Registration was Successful", "OK");
        }
    }
}