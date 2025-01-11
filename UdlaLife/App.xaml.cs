using UdlaLife.Data;
using UdlaLife.Views;

namespace UdlaLife
{
    public partial class App : Application
    {
        public static DatabaseService DatabaseService { get; private set; }

        public App()
        {
            InitializeComponent();

            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "UDLADatabase.db3");
            DatabaseService = new DatabaseService(dbPath);

            MainPage = new NavigationPage(new HomePage());
        }
    }

}