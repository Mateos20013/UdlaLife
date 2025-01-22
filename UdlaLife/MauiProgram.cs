using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace UdlaLife;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>() // Especifica explícitamente el tipo de App
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Inicialización de la base de datos
        var databasePath = Path.Combine(FileSystem.AppDataDirectory, "udla.db");
        App.Database = new Data.DatabaseService(databasePath);

        return builder.Build();
    }
}
