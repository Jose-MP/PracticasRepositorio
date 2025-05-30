﻿
using AgendaDeContactos.Datos;
using AgendaDeContactos.Modelos;

namespace AgendaDeContactos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private ContactoDatabase db = new ContactoDatabase();

        public MainPage()
        {
            InitializeComponent();
        }       
        private async void IrListaContactos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactosPage());
        }

        private async void IrCrearContacto(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearContactoPage());
        }

        private async void IrConfiguracion(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfiguracionPage());
        }
    }

}
