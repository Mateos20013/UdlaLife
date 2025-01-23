using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.Maui.Storage;
using UdlaLife.Models;
using UdlaLife.Data;
using UdlaLife.Views;

namespace UdlaLife.ViewModel
{
    public class EstudianteActividadesViewModel
    {
        public ObservableCollection<Actividad> Actividades { get; set; }
        public Command SubirTareaCommand { get; }

        public EstudianteActividadesViewModel()
        {
            Actividades = new ObservableCollection<Actividad>();
            LoadActividades();
            SubirTareaCommand = new Command(OnSubirTareaClicked); // Comando para el botón "Subir Tarea"
        }

        private async void LoadActividades()
        {
            var actividades = await App.Database.GetActividadesAsync();
            foreach (var actividad in actividades)
            {
                Actividades.Add(actividad);
            }
        }

        private async void OnSubirTareaClicked()
        {
            // Aquí puedes agregar la lógica para navegar a la página de "Subir Tarea"
            await Application.Current.MainPage.Navigation.PushAsync(new SubirTareaPage());
        }
    }
}
