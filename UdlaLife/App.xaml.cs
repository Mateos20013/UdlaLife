using System.IO;
using UdlaLife.Data;
using UdlaLife.Views;

namespace UdlaLife
{
    public partial class App : Application
    {
        public static DatabaseService Database { get; private set; }

        public App()
        {
            InitializeComponent();

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "udla.db");
            Database = new DatabaseService(databasePath);

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
