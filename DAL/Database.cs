using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeKoelkast.Models;
using System.IO;

namespace DeKoelkast.DAL
{
    public class Database
    {
        private static SQLiteAsyncConnection _database;

        public static SQLiteAsyncConnection GetDatabase()
        {
            if (_database == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Project.db");
                _database = new SQLiteAsyncConnection(dbPath);

                // Tabellen aanmaken
                _database.CreateTableAsync<User>().Wait();
            }

            return _database;
        }
    }
}
