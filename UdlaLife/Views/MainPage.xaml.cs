using Microsoft.Maui.Controls;

namespace UdlaLife.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnEstudianteClicked(object sender, EventArgs e)
    {
        // Cambia la navegación para ir primero a LoginPage
        await Navigation.PushAsync(new LoginPage());
    }

    private async void OnProfesorClicked(object sender, EventArgs e)
    {
        // Cambia la navegación para ir primero a LoginPage
        await Navigation.PushAsync(new LoginPage());
    }

    private async void OnRegistrarseClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }
}
