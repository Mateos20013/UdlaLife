using SQLite;
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

        // Método para obtener un estudiante por email y contraseña
        public async Task<Estudiante?> GetEstudianteByEmailAndPasswordAsync(string email, string password)
        {
            return await _database.Table<Estudiante>()
                                  .FirstOrDefaultAsync(e => e.Email == email && e.Password == password);
        }

        // Otros métodos existentes
        public Task<int> SaveEstudianteAsync(Estudiante estudiante)
        {
            return _database.InsertAsync(estudiante);
        }

        public Task<int> UpdateAsistenciaAsync(Estudiante estudiante)
        {
            return _database.UpdateAsync(estudiante);
        }

        public Task<List<Estudiante>> GetEstudiantesAsync()
        {
            return _database.Table<Estudiante>().ToListAsync();
        }
    }
}
