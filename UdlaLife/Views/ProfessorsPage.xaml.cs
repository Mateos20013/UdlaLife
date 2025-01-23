using Microsoft.Maui.Controls;
using System;
using UdlaLife.Views;

namespace UdlaLife.Views
{
    public partial class ProfessorsPage : ContentPage
    {
        public ProfessorsPage()
        {
            InitializeComponent();
        }

        private async void OnGoToTareasClicked(object sender, EventArgs e)
        {
            // Navegar a la página de tareas
            await Navigation.PushAsync(new SubirTareaPage());
        }

        private async void OnActividadesClicked(object sender, EventArgs e)
        {
            // Aquí puedes implementar la lógica para crear una nueva actividad
            await DisplayAlert("Crear Actividad", "Se creó una nueva actividad.", "OK");
        }
    }
}
