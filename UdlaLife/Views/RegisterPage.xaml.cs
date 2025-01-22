using Microsoft.Maui.Controls;
using System;
using UdlaLife.Data;
using UdlaLife.Models;

namespace UdlaLife.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text ?? string.Empty;
            string apellido = ApellidoEntry.Text ?? string.Empty;
            string email = EmailEntry.Text ?? string.Empty;
            string password = PasswordEntry.Text ?? string.Empty;
            string rol = RolPicker.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(rol))
            {
                await DisplayAlert("Error", "Por favor, llena todos los campos.", "OK");
                return;
            }

            await App.Database.SaveEstudianteAsync(new Estudiante
            {
                Nombre = nombre,
                Apellido = apellido,
                Email = email,
                Password = password,
                Rol = rol
            });

            await DisplayAlert("Éxito", "Usuario registrado exitosamente.", "OK");
            await Navigation.PopAsync();
        }
    }
}
