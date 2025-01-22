using Microsoft.Maui.Controls;
using System;
using UdlaLife.Views;

namespace UdlaLife.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnStudentClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage("Estudiante"));
        }

        private async void OnProfessorClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage("Profesor"));
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
