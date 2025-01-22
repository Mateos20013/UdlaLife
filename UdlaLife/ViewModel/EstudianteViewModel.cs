using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using UdlaLife.Data;
using UdlaLife.Models;

namespace UdlaLife.ViewModels;

public class EstudianteViewModel : BaseViewModel
{
    private readonly DatabaseService _databaseService;

    public ObservableCollection<Estudiante> Estudiantes { get; set; } = new();

    public ICommand LoadStudentsCommand { get; }

    public EstudianteViewModel(DatabaseService databaseService)
    {
        _databaseService = databaseService;
        LoadStudentsCommand = new Command(async () => await LoadStudentsAsync());
    }

    private async Task LoadStudentsAsync()
    {
        var students = await _databaseService.GetStudentsAsync();
        Estudiantes.Clear();
        foreach (var student in students)
        {
            Estudiantes.Add(student);
        }
    }
}
