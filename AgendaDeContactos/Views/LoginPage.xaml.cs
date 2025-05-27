using AgendaDeContactos.Services;
using AgendaDeContactos.Modelos;

namespace AgendaDeContactos.Views
{
    public partial class LoginPage : ContentPage
    {
        private readonly DatabaseService _databaseService;

        public LoginPage()
        {
            InitializeComponent();
            _databaseService = new DatabaseService();
        }

        protected override bool OnBackButtonPressed()
        {
            Application.Current.Quit();
            return true;
        }

        private async void TapGestureRecognizerPwd_Tapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync("///contra"); // Mantiene tu ruta original
        }

        private async void TapGestureRecognizerReg_Tapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync("///registro"); // Mantiene tu ruta original
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            var nombre = NombreEntry.Text?.Trim();
            var password = PasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Error", "Debes ingresar nombre y contraseña", "OK");
                return;
            }

            var usuario = await _databaseService.ValidarLogin(nombre, password);

            if (usuario != null)
            {
                Preferences.Set("UsuarioActual", usuario.Nombre);
                await SecureStorage.SetAsync("hasAuth", "true");
                await Shell.Current.GoToAsync("///main"); // Mantiene tu ruta original
            }
            else
            {
                await DisplayAlert("Error", "Nombre de usuario o contraseña incorrectos", "OK");
            }
        }
    }
}