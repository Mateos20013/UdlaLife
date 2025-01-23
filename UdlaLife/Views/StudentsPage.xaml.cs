using Microsoft.Maui.Controls;
using System;
using UdlaLife.ViewModel;
using UdlaLife.Views;



namespace UdlaLife.Views
{
    public partial class StudentsPage : ContentPage
    {
        public StudentsPage()
        {
            InitializeComponent();
            BindingContext = new EstudianteViewModel(App.Database);
        }

        private async void OnTareasClicked(object sender, EventArgs e)
        {
            // Navegar a la p�gina de subir tareas
            await Navigation.PushAsync(new SubirTareaPage());
        }

    }
}
