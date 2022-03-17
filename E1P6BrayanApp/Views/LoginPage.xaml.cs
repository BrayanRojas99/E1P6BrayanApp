using E1P6BrayanApp.ViewModels;
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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        private void CmdSeePassword(object sender, ToggledEventArgs e)
        {
            if (SwSeePassword.IsToggled)
            {
                TxtPassword.IsPassword = false;
            }
            else
            {
                TxtPassword.IsPassword = true;
            }
        }

        private async void CmdUserInicio(object sender, EventArgs e)
        {
            
            try
            {
                string email = TxtUserName.Text.Trim();
                string clave = TxtPassword.Text.Trim();
                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(clave))
                {
                    if (email.Equals("1") && clave.Equals("2"))
                    {
                        await Navigation.PushAsync(new ActivoRegisterPage());//colocar el formulario por arriba el otro usuario
                    }
                    else
                    {
                        await DisplayAlert("Error", "Informacion incorrecta", "OK");
                    }
                }
                else
                {
                    await DisplayAlert("Error", "Informacion incompleta", "OK");
                }

            }
            catch (Exception ex)
            {

                await DisplayAlert("Error", "Informacion incompleta", "OK");
            }
            
                
            


        }

        private async void CmdSalir(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}