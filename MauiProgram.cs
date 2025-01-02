using DeKoelkast.Helpers;
using Microsoft.Extensions.Logging;
using SQLite;

namespace DeKoelkast
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            InitializeDatabase();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        private static async void InitializeDatabase()
        {
            string databaseName = "DeKoelkast.db";
            string dbPath = await DatabaseInitializer.InitializeDatabaseAsync(databaseName);

            // Test of het pad correct is
            Console.WriteLine($"Database pad: {dbPath}");
        }
    }
}
