using AgendaDeContactos.Services;

namespace AgendaDeContactos.Views
{
    public partial class ContrasenaPage : ContentPage
    {
        private readonly DatabaseService _dbService;

        public ContrasenaPage()
        {
            InitializeComponent();
            _dbService = new DatabaseService();
        }

        private async void OnActualizarClicked(object sender, EventArgs e)
        {
            var correo = CorreoEntry.Text?.Trim();
            var nuevaPassword = NuevaPasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(correo) || !correo.Contains("@"))
            {
                await DisplayAlert("Error", "Ingrese un correo v�lido", "OK");
                return;
            }

            if (NuevaPasswordEntry.Text != ConfirmPasswordEntry.Text)
            {
                await DisplayAlert("Error", "Las contrase�as no coinciden", "OK");
                return;
            }

            if (await _dbService.ActualizarPassword(correo, nuevaPassword))
            {
                await DisplayAlert("�xito", "Contrase�a actualizada", "OK");
                await Shell.Current.GoToAsync("//login");
            }
            else
            {
                await DisplayAlert("Error", "Correo no registrado", "OK");
            }
        }
    }
}