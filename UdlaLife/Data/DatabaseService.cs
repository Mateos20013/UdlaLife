using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using UdlaLife.Models;

namespace UdlaLife.Data
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Estudiante>().Wait();
        }

        public Task<List<Estudiante>> GetEstudiantesAsync()
        {
            return _database.Table<Estudiante>().ToListAsync();
        }

        public Task<Estudiante> GetEstudianteByEmailAndPasswordAsync(string email, string password)
        {
            return _database.Table<Estudiante>().FirstOrDefaultAsync(e => e.Email == email && e.Password == password);
        }

        public Task<int> SaveEstudianteAsync(Estudiante estudiante)
        {
            return _database.InsertAsync(estudiante);
        }
    }
}
