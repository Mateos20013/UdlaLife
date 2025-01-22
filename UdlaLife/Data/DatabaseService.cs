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

    public Task<List<Estudiante>> GetStudentsAsync()
    {
        return _database.Table<Estudiante>().ToListAsync();
    }

    public Task<int> SaveStudentAsync(Estudiante estudiante)
    {
        return _database.InsertAsync(estudiante);
    }

    public Task<int> DeleteStudentAsync(Estudiante estudiante)
    {
        return _database.DeleteAsync(estudiante);
    }
}
