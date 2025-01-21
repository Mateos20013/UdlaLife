using Microsoft.Maui.Controls;
using UdlaLife.ViewModels;

namespace UdlaLife.Views;

public partial class StudentsPage : ContentPage
{
    public StudentsPage()
    {
        InitializeComponent();
        BindingContext = new EstudianteViewModel(App.Database);
    }
}
