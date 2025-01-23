using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using UdlaLife.Models;

namespace UdlaLife.Data
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            // Crear las tablas necesarias en la base de datos
            _database.CreateTableAsync<Estudiante>().Wait();
            _database.CreateTableAsync<Actividad>().Wait();
        }

        // Obtener un estudiante por email y contraseña
        public async Task<Estudiante> GetEstudianteByEmailAndPasswordAsync(string email, string password)
        {
            return await _database.Table<Estudiante>()
                                  .Where(e => e.Email == email && e.Password == password)
                                  .FirstOrDefaultAsync();
        }

        // Guardar un estudiante en la base de datos
        public async Task<int> SaveEstudianteAsync(Estudiante estudiante)
        {
            return await _database.InsertAsync(estudiante);
        }

        // Obtener todas las actividades
        public async Task<List<Actividad>> GetActividadesAsync()
        {
            return await _database.Table<Actividad>().ToListAsync();
        }

        // Obtener todos los estudiantes
        public async Task<List<Estudiante>> GetEstudiantesAsync()
        {
            return await _database.Table<Estudiante>().ToListAsync();
        }

        // Guardar una actividad
        public async Task<int> SaveActividadAsync(Actividad actividad)
        {
            return await _database.InsertAsync(actividad);
        }

        // Actualizar una actividad
        public async Task<int> UpdateActividadAsync(Actividad actividad)
        {
            return await _database.UpdateAsync(actividad);
        }

        // Actualizar asistencia de un estudiante
        public async Task<int> UpdateAsistenciaAsync(Estudiante estudiante)
        {
            return await _database.UpdateAsync(estudiante);
        }
    }
}
