using System;
using System.IO;
using System.Threading.Tasks;

namespace DeKoelkast.Helpers
{
    public static class DatabaseInitializer
    {
        public static async Task<string> InitializeDatabaseAsync(string databaseName)
        {
            // Schrijfbare locatie voor de database
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, databaseName);

            // Controleer of de database al bestaat
            if (!File.Exists(dbPath))
            {
                // Kopieer de database vanuit de Resources/Raw-map
                using var stream = await FileSystem.OpenAppPackageFileAsync(databaseName);
                using var newStream = File.Create(dbPath);
                await stream.CopyToAsync(newStream);
            }

            return dbPath;
        }
    }
}
