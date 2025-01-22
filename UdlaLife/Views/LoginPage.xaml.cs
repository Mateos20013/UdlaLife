using Microsoft.Maui.Controls;
using System;
using UdlaLife.Data;

namespace UdlaLife.Views
{
    public partial class LoginPage : ContentPage
    {
        private readonly string _rol;

        public LoginPage(string rol)
        {
            InitializeComponent();
            _rol = rol;
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Error", "Por favor, ingresa tus credenciales.", "OK");
                return;
            }

            var user = await App.Database.GetEstudianteByEmailAndPasswordAsync(email, password);

            if (user != null && user.Rol == _rol)
            {
                await DisplayAlert("Éxito", "Inicio de sesión exitoso.", "OK");
                if (_rol == "Estudiante")
                    await Navigation.PushAsync(new StudentsPage());
                else if (_rol == "Profesor")
                    await Navigation.PushAsync(new ProfessorsPage());
            }
            else
            {
                await DisplayAlert("Error", "Credenciales incorrectas o rol incorrecto.", "OK");
            }
        }
    }
}
