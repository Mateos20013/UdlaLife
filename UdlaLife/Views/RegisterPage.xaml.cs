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
        await DisplayAlert("Registro", "Registro exitoso.", "OK");
        await Navigation.PopAsync(); // Regresa a la página anterior
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage()); // Navega a la página de inicio de sesión
    }
}
