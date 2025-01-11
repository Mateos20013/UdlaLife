using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdlaLife.Data;
using UdlaLife.Models;
using UdlaLife.ViewModel;

namespace UdlaLife.ViewModels
{
    public class EstudentViewModel : BaseViewModel
    {
        private readonly DatabaseService _databaseService;
        public ObservableCollection<Estudiante> Estudiante { get; set; }

        public EstudentViewModel(DatabaseService databaseService)
        {
            _databaseService = databaseService;
            Estudiante = new ObservableCollection<Estudiante>();
        }

        public async Task LoadStudents()
        {
            var students = await _databaseService.GetStudentsAsync();
            foreach (var student in students)
            {
                Estudiante.Add(student);
            }
        }
    }
}
