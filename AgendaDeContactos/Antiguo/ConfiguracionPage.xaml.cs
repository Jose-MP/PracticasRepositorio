namespace AgendaDeContactos;

public partial class ConfiguracionPage : ContentPage
{
    public ConfiguracionPage()
    {
        InitializeComponent();
    }
    private async void LogoutButton_Clicked(object sender, EventArgs e)
    {
        if (await DisplayAlert("Are you sure?", "You will be logged out.", "Yes", "No"))
        {
            Preferences.Remove("UsuarioActual");
            SecureStorage.RemoveAll();
            await Shell.Current.GoToAsync("///login");
        }
    }
}