using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using UdlaLife.Models;

namespace UdlaLife.Views
{
    public partial class ProfesorActividadesPage : ContentPage
    {
        public ObservableCollection<Actividad> Actividades { get; set; }

        public ProfesorActividadesPage()
        {
            InitializeComponent();
            Actividades = new ObservableCollection<Actividad>();
            BindingContext = this;
        }

        private async void OnSaveActividadClicked(object sender, EventArgs e)
        {
            var nuevaActividad = new Actividad
            {
                Titulo = TituloEntry.Text,
                Descripcion = DescripcionEditor.Text,
                Profesor = "Profesor Nombre" // Puedes reemplazar con datos reales
            };

            await App.Database.SaveActividadAsync(nuevaActividad);
            Actividades.Add(nuevaActividad);

            await DisplayAlert("Éxito", "Actividad creada exitosamente", "OK");
        }
    }
}
