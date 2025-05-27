using SQLite;
using AgendaDeContactos.Modelos;
using System.Diagnostics;

namespace AgendaDeContactos.Services
{
    public class DatabaseService
    {
        private SQLiteAsyncConnection _db;

        public DatabaseService()
        {
            InitializeDatabase();
        }

        private async void InitializeDatabase()
        {
            try
            {
                string dbPath = Path.Combine(FileSystem.AppDataDirectory, "usuarios.db3");
                Debug.WriteLine($"Ruta BD: {dbPath}");

                _db = new SQLiteAsyncConnection(dbPath);
                await _db.CreateTableAsync<Usuarios>();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error BD: {ex.Message}");
            }
        }

        public async Task<bool> RegistrarUsuario(Usuarios usuario)
        {
            try
            {
                await _db.InsertAsync(usuario);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error registro: {ex.Message}");
                return false;
            }
        }

        public async Task<Usuarios> ValidarLogin(string nombre, string password)
        {
            return await _db.Table<Usuarios>()
                          .Where(u => u.Nombre == nombre && u.Password == password)
                          .FirstOrDefaultAsync();
        }

        public async Task<bool> ActualizarPassword(string correo, string nuevaPassword)
        {
            var usuario = await _db.Table<Usuarios>()
                                .Where(u => u.Correo == correo)
                                .FirstOrDefaultAsync();

            if (usuario != null)
            {
                usuario.Password = nuevaPassword;
                await _db.UpdateAsync(usuario);
                return true;
            }
            return false;
        }

        public async Task<bool> CorreoExiste(string correo)
        {
            return await _db.Table<Usuarios>()
                         .Where(u => u.Correo == correo)
                         .CountAsync() > 0;
        }
    }
}