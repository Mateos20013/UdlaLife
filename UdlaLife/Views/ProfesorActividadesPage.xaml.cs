using Microsoft.Maui.Controls;
using System;
using UdlaLife.Models;

namespace UdlaLife.Views
{
    public partial class ProfesorActividadesPage : ContentPage
    {
        public ProfesorActividadesPage()
        {
            InitializeComponent();
        }

        private async void OnSaveActividadClicked(object sender, EventArgs e)
        {
            var nuevaActividad = new Actividad
            {
                Titulo = TituloEntry.Text,
                Descripcion = DescripcionEditor.Text,
                Profesor = "Profesor Nombre" // Aquí puedes agregar el nombre real del profesor
            };

            await App.Database.SaveActividadAsync(nuevaActividad);
            await DisplayAlert("Éxito", "Actividad creada exitosamente", "OK");
        }
    }
}
