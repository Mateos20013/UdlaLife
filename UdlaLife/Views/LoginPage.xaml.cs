using Microsoft.Maui.Controls;
using System;
using UdlaLife.Data;

namespace UdlaLife.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
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

        // Valida las credenciales en la base de datos
        var user = await App.Database.GetEstudianteByEmailAndPasswordAsync(email, password);
        if (user != null)
        {
            await DisplayAlert("Éxito", "Inicio de sesión exitoso.", "OK");
            // Navega según el rol del usuario
            if (user.Rol == "Estudiante")
            {
                await Navigation.PushAsync(new StudentsPage());
            }
            else if (user.Rol == "Profesor")
            {
                await Navigation.PushAsync(new ProfessorsPage());
            }
        }
        else
        {
            await DisplayAlert("Error", "Credenciales incorrectas.", "OK");
        }
    }
}
