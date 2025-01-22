using Microsoft.Maui.Controls;
using UdlaLife.Models;

namespace UdlaLife.Views
{
    public partial class StudentAttendancePage : ContentPage
    {
        public StudentAttendancePage(Estudiante estudiante)
        {
            InitializeComponent();
            BindingContext = estudiante; // Enlaza el estudiante recibido
        }
    }
}
