using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UdlaLife.Data;
using UdlaLife.Models;

namespace UdlaLife.ViewModels;

public class EstudentViewModel : BaseViewModel
{
    private readonly DatabaseService _databaseService;
    public ObservableCollection<Estudiante> Estudiantes { get; set; } = new();

    public EstudentViewModel(DatabaseService databaseService)
    {
        _databaseService = databaseService;
    }

    // Método para cargar los estudiantes desde la base de datos
    public async Task LoadStudents()
    {
        var students = await _databaseService.GetStudentsAsync();
        Estudiantes.Clear();
        foreach (var student in students)
        {
            Estudiantes.Add(student);
        }
    }
}
