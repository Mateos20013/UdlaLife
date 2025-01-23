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
            SubirTareaCommand = new Command(OnSubirTareaClicked);
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
            // Lógica para navegar a la página de SubirTareaPage
            await Application.Current.MainPage.Navigation.PushAsync(new SubirTareaPage());
        }
    }
}
