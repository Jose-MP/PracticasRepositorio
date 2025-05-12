namespace AgendaDeContactos.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    protected override bool OnBackButtonPressed()
    {
        Application.Current.Quit();
        return true;
    }

    private async void TapGestureRecognizerPwd_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("///contra");
    }

    private async void TapGestureRecognizerReg_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("///registro");
    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        if (IsCredentialCorrect(Username.Text, Password.Text))
        {
            Preferences.Set("UsuarioActual", Username.Text.Trim());
            await SecureStorage.SetAsync("hasAuth", "true");
            await Shell.Current.GoToAsync("///main"); // Navega al tab de inicio
        }
        else
        {
            Preferences.Remove("UsuarioActual");
            await DisplayAlert("Login failed", "Username or password is invalid", "Try again");
        }
    }

    bool IsCredentialCorrect(string username, string password)
    {
        return username == "admin" && password == "1234";
    }
}
