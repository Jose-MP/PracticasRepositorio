using SQLite;

namespace AgendaDeContactos.Modelos;

public class Contacto
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Telefono { get; set; }
    public string? CorreoElectronico { get; set; }
    public bool Activo { get; set; }
}

