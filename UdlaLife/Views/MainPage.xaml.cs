using Microsoft.Maui.Controls;
using System;

namespace UdlaLife.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Lógica cuando el estudiante hace clic en su botón
        private async void OnStudentClicked(object sender, EventArgs e)
        {
            // Navegar a la página de login de estudiante
            await Navigation.PushAsync(new LoginPage("Estudiante"));
        }

        // Lógica cuando el profesor hace clic en su botón
        private async void OnProfessorClicked(object sender, EventArgs e)
        {
            // Navegar a la página de login de profesor
            await Navigation.PushAsync(new LoginPage("Profesor"));
        }

        // Lógica para navegar a la página de registro
        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            // Aquí puedes redirigir a la página de registro
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
