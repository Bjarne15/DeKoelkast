using SQLite;
using System.Collections.Generic;
using DeKoelkast.Models;

namespace DeKoelkast.Services
{
    public class DatabaseService
    {
        private readonly SQLiteConnection _connection;

        public DatabaseService(string dbPath)
        {
            _connection = new SQLiteConnection(dbPath);
        }

        public List<Fridge> GetFridges()
        {
            return _connection.Table<Fridge>().ToList();
        }

        // Voeg hier meer methodes toe voor andere tabellen, bijvoorbeeld:
        // - GetInventory()
        // - AddUser()
        // - UpdateInventory()
    }
}
