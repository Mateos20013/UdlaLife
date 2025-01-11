using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;
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
            _database.CreateTableAsync<Curso>().Wait();
        }

        public Task<List<Estudiante>> GetStudentsAsync() =>
        _database.Table<Estudiante>().ToListAsync();

        public Task<List<Curso>> GetCoursesAsync() =>
            _database.Table<Curso>().ToListAsync();

        public Task<int> SaveStudentAsync(Estudiante Estudiante) =>
        _database.InsertOrReplaceAsync(Estudiante);

        public Task<int> SaveCourseAsync(Curso curso) =>
            _database.InsertOrReplaceAsync(curso);
    }

}
