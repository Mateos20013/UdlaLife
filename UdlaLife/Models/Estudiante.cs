using SQLite;

namespace UdlaLife.Models;

[Table("Estudiantes")]
public class Estudiante
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [MaxLength(100)]
    public string Nombre { get; set; }

    [MaxLength(100)]
    public string Apellido { get; set; }

    [Unique, MaxLength(150)]
    public string Email { get; set; }

    [MaxLength(50)]
    public string Password { get; set; }

    public string Rol { get; set; }
}
