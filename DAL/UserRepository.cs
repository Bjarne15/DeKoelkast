using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeKoelkast.Models;

namespace DeKoelkast.DAL
{
    public class UserRepository
    {
        private readonly SQLiteAsyncConnection _database;

        public UserRepository()
        {
            _database = Database.GetDatabase();
        }

        // Gebruiker opslaan
        public Task<int> AddUserAsync(User user)
        {
            return _database.InsertAsync(user);
        }

        // Gebruiker ophalen op basis van gebruikersnaam
        public Task<User> GetUserByUsernameAsync(string username)
        {
            return _database.Table<User>().FirstOrDefaultAsync(u => u.Username == username);
        }

        // Wachtwoord controleren
        public async Task<bool> VerifyLoginAsync(string username, string password)
        {
            var user = await GetUserByUsernameAsync(username);
            return user != null && PasswordHelper.VerifyPassword(password, user.PasswordHash);
        }
    }
}
