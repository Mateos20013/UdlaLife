using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UdlaLife.Data;
using UdlaLife.Models;

namespace UdlaLife.ViewModels;

public class EstudianteViewModel
{
    private readonly DatabaseService _databaseService;

    public ObservableCollection<Estudiante> Estudiantes { get; set; } = new();

    public EstudianteViewModel(DatabaseService databaseService)
    {
        _databaseService = databaseService;
        _ = LoadStudentsAsync(); // Carga los estudiantes al inicializar
    }

    public async Task LoadStudentsAsync()
    {
        var students = await _databaseService.GetStudentsAsync();
        Estudiantes.Clear();
        foreach (var student in students)
        {
            Estudiantes.Add(student);
        }
    }
}
