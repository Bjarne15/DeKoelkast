using System.IO;

namespace DeKoelkast.Helpers
{
    public static class DatabaseHelper
    {
        public static string GetDatabasePath(string databaseName)
        {
#if ANDROID
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
#elif IOS
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folderPath = Path.Combine(folderPath, "..", "Library");
#else
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
#endif
            return Path.Combine(folderPath, databaseName);
        }
    }
}
