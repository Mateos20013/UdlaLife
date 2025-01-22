using Microsoft.Maui.Controls;
using UdlaLife.ViewModels;

namespace UdlaLife.Views;

public partial class StudentsPage : ContentPage
{
    public StudentsPage()
    {
        InitializeComponent();

        // Configurar el BindingContext con el ViewModel
        BindingContext = new EstudianteViewModel(App.Database);
    }
}
