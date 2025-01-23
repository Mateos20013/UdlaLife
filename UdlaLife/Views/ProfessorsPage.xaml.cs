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
            // Navegar a la p�gina de tareas
            await Navigation.PushAsync(new SubirTareaPage());
        }

        private async void OnActividadesClicked(object sender, EventArgs e)
        {
            // Aqu� puedes implementar la l�gica para crear una nueva actividad
            await DisplayAlert("Crear Actividad", "Se cre� una nueva actividad.", "OK");
        }
    }
}
