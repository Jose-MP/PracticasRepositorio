using AgendaDeContactos.Modelos;
using AgendaDeContactos.Services;

namespace AgendaDeContactos.Views
{
    public partial class RegistroPage : ContentPage
    {
        private readonly DatabaseService _dbService;

        public RegistroPage()
        {
            InitializeComponent();
            _dbService = new DatabaseService();
        }

        private async void OnRegistroClicked(object sender, EventArgs e)
        {
            var usuario = new Usuarios
            {
                Nombre = NombreEntry.Text?.Trim(),  
                Correo = CorreoEntry.Text?.Trim(),
                Password = PasswordEntry.Text
            };

            // Validaciones
            if (string.IsNullOrWhiteSpace(usuario.Nombre))
            {
                await DisplayAlert("Error", "El nombre es obligatorio", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(usuario.Correo) || !usuario.Correo.Contains("@"))
            {
                await DisplayAlert("Error", "Correo electr�nico inv�lido", "OK");
                return;
            }

            if (PasswordEntry.Text != ConfirmPasswordEntry.Text)
            {
                await DisplayAlert("Error", "Las contrase�as no coinciden", "OK");
                return;
            }

            if (await _dbService.CorreoExiste(usuario.Correo))
            {
                await DisplayAlert("Error", "Este correo ya est� registrado", "OK");
                return;
            }

            if (await _dbService.RegistrarUsuario(usuario))
            {
                await DisplayAlert("�xito", "Registro completado", "OK");
                await Shell.Current.GoToAsync("//login");
            }
            else
            {
                await DisplayAlert("Error", "No se pudo completar el registro", "OK");
            }
        }
    }
}