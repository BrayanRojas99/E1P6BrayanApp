using E1P6BrayanApp.ViewModels;
using E1P6BrayanApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace E1P6BrayanApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
