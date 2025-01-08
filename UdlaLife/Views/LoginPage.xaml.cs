using System;
using Microsoft.Maui.Controls;

namespace UdlaLife.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Aquí iría la lógica de autenticación
        await DisplayAlert("Login", "Inicio de sesión exitoso", "OK");
    }
}
