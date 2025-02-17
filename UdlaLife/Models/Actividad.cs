﻿using SQLite;

namespace UdlaLife.Models
{
 public class Actividad
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public string Profesor { get; set; } // Profesor que crea la actividad
    public string ArchivoTarea { get; set; } // Archivo subido por el estudiante
}

    }
