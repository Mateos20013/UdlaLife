using System;
using Microsoft.Maui.Controls;

namespace UdlaLife.Views;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Registro", "Usuario registrado exitosamente", "OK");
    }
}
