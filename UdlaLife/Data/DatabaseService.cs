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
        _database.CreateTableAsync<Estudiante>().Wait();
    }

    // Método para obtener todos los estudiantes de la base de datos
    public Task<List<Estudiante>> GetStudentsAsync()
    {
        return _database.Table<Estudiante>().ToListAsync();
    }

    // Método para guardar un estudiante
    public Task<int> SaveStudentAsync(Estudiante estudiante)
    {
        return _database.InsertAsync(estudiante);
    }

    // Método para eliminar un estudiante
    public Task<int> DeleteStudentAsync(Estudiante estudiante)
    {
        return _database.DeleteAsync(estudiante);
    }
}
