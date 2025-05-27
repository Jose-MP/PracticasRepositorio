using SQLite;

namespace AgendaDeContactos.Modelos
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull, MaxLength(100)]
        public string Nombre { get; set; }

        [NotNull, Unique, MaxLength(100)]
        public string Correo { get; set; }

        [NotNull]
        public string Password { get; set; }
    }
}