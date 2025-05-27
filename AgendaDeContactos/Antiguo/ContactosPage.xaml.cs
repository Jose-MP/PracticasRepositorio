using AgendaDeContactos.Datos;
using AgendaDeContactos.Modelos;

namespace AgendaDeContactos;

public partial class ContactosPage : ContentPage
{
    int count = 0;
    private ContactoDatabase db = new ContactoDatabase();
    public ContactosPage()
    {
        InitializeComponent();

    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        contactosView.ItemsSource = await db.ObtenerContactosAsync();
    }
    private async void OnContactoSeleccionado(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Contacto seleccionado)
        {
            await Navigation.PushAsync(new CrearContactoPage(seleccionado));
        }
    }

    private async void OnEliminarContacto(object sender, EventArgs e)
    {
        if (((SwipeItem)sender).BindingContext is Contacto contacto)
        {
            bool confirm = await DisplayAlert("Confirmar", $"¿Eliminar a {contacto.Nombre}?", "Sí", "No");
            if (confirm)
            {

                await db.EliminarContactoAsync(contacto);
                contactosView.ItemsSource = await db.ObtenerContactosAsync();
            }
        }
    }

}