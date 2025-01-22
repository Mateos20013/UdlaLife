using Microsoft.Maui.Controls;
using System;
using UdlaLife.Data;
using UdlaLife.Models;

namespace UdlaLife.Views
{
    public partial class LoginPage : ContentPage
    {
        private readonly string UserRole;

        public LoginPage(string role)
        {
            InitializeComponent();
            UserRole = role;
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
            if (user != null && user.Rol == UserRole)
            {
                await DisplayAlert("Éxito", "Inicio de sesión exitoso.", "OK");
                if (UserRole == "Estudiante")
                {
                    await Navigation.PushAsync(new StudentAttendancePage(user));
                }
                else
                {
                    await Navigation.PushAsync(new AttendancePage());
                }
            }
            else
            {
                await DisplayAlert("Error", "Credenciales incorrectas.", "OK");
            }
        }
    }
}
