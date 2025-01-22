using UdlaLife.Data;

namespace UdlaLife;

public partial class App : Application
{
    public static DatabaseService Database { get; set; } // Hacer que el setter sea público

    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }

    public App(string databasePath)
    {
        InitializeComponent();
        Database = new DatabaseService(databasePath);
        MainPage = new AppShell();
    }
}
