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
        // Aqu� ir�a la l�gica de autenticaci�n
        await DisplayAlert("Login", "Inicio de sesi�n exitoso", "OK");
    }
}
