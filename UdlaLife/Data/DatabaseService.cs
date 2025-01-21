using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using UdlaLife.Models;

namespace UdlaLife.Data;

public class DatabaseService
{
    private readonly SQLiteAsyncConnection _database;

    public DatabaseService(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<Estudiante>().Wait(); // Crea la tabla si no existe
    }

    // Método para obtener todos los estudiantes
    public Task<List<Estudiante>> GetStudentsAsync()
    {
        return _database.Table<Estudiante>().ToListAsync();
    }

    // Método para guardar un estudiante
    public Task<int> SaveEstudianteAsync(Estudiante estudiante)
    {
        return _database.InsertAsync(estudiante);
    }

    // Método para obtener un estudiante por correo y contraseña
    public Task<Estudiante?> GetEstudianteByEmailAndPasswordAsync(string email, string password)
    {
        return _database.Table<Estudiante>()
                        .FirstOrDefaultAsync(e => e.Email == email && e.Password == password);
    }
}
