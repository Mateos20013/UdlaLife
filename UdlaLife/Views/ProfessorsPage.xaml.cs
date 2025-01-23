using Microsoft.Maui.Controls;
using System;

namespace UdlaLife.Views
{
    public partial class ProfessorsPage : ContentPage
    {
        public ProfessorsPage()
        {
            InitializeComponent();
        }

        private async void OnActividadesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfesorActividadesPage());
        }
    }
}
