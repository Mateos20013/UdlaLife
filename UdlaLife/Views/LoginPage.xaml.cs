namespace UdlaLife.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Simula el inicio de sesión.
        await Navigation.PushAsync(new MainPage());
    }
}
