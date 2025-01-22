using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;
using UdlaLife.Data;
using UdlaLife.Models;

namespace UdlaLife.Views
{
    public partial class AttendancePage : ContentPage
    {
        public ObservableCollection<Estudiante> Estudiantes { get; set; }
        public ICommand SaveCommand { get; }

        public AttendancePage()
        {
            InitializeComponent();

            Estudiantes = new ObservableCollection<Estudiante>();
            SaveCommand = new Command(SaveAttendance);

            BindingContext = this;

            LoadStudents();
        }

        private async void LoadStudents()
        {
            var estudiantes = await App.Database.GetEstudiantesAsync();
            foreach (var estudiante in estudiantes)
            {
                Estudiantes.Add(estudiante);
            }
        }

        private async void SaveAttendance()
        {
            foreach (var estudiante in Estudiantes)
            {
                await App.Database.UpdateAsistenciaAsync(estudiante);
            }

            await DisplayAlert("Éxito", "Asistencia guardada correctamente.", "OK");
        }
    }
}
