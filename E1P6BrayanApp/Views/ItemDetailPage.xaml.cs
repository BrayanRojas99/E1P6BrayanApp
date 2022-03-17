using E1P6BrayanApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace E1P6BrayanApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}