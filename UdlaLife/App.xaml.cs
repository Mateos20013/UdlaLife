using UdlaLife.Data;
using Microsoft.Maui.Controls;

namespace UdlaLife;

public partial class App : Application
{
    public static DatabaseService Database { get; set; } // Cambiado a 'set' público

    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}
