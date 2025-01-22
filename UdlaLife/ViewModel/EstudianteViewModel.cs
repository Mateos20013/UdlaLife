using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UdlaLife.Data;
using UdlaLife.Models;

namespace UdlaLife.ViewModel
{
    public class EstudianteViewModel
    {
        private readonly DatabaseService _databaseService;

        public ObservableCollection<Estudiante> Estudiantes { get; set; } = new();

        public EstudianteViewModel(DatabaseService databaseService)
        {
            _databaseService = databaseService;
            _ = LoadStudentsAsync();
        }

        public async Task LoadStudentsAsync()
        {
            var students = await _databaseService.GetEstudiantesAsync();
            Estudiantes.Clear();
            foreach (var student in students)
            {
                Estudiantes.Add(student);
            }
        }
    }
}
