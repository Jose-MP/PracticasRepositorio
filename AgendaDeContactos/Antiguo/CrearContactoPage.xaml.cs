using AgendaDeContactos.Datos;
using AgendaDeContactos.Modelos;

namespace AgendaDeContactos;

public partial class CrearContactoPage : ContentPage
{
    private ContactoDatabase db = new ContactoDatabase();
    private Contacto contacto;

    public CrearContactoPage()
    {
        InitializeComponent();

        contacto = new Contacto();

    }
    public CrearContactoPage(Contacto c)
    {
        InitializeComponent();

        contacto = c;

        nombreEntry.Text = contacto.Nombre;
        telefonoEntry.Text = contacto.Telefono;
        correoEntry.Text = contacto.CorreoElectronico;
    }

    private async void OnGuardarClicked(object sender, EventArgs e)
    {

        if (string.IsNullOrWhiteSpace(nombreEntry.Text) ||
            string.IsNullOrWhiteSpace(telefonoEntry.Text) ||
            string.IsNullOrWhiteSpace(correoEntry.Text))
        {
            await DisplayAlert("Campos requeridos", "Todos los campos son obligatorios.", "OK");
            return;
        }

        contacto.Nombre = nombreEntry.Text;
        contacto.Telefono = telefonoEntry.Text;
        contacto.CorreoElectronico = correoEntry.Text;

        await db.GuardarContactoAsync(contacto);
        await Navigation.PopAsync();
    }

}