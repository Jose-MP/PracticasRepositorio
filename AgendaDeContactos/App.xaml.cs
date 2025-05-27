using AgendaDeContactos.Utils;

namespace AgendaDeContactos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderLine", (handler, view) =>
            {
                // Aquí podrías agregar un mapeo específico si es necesario
                //(handler.PlatformView as Android.Views.View).SetBackgroundColor(Microsoft.Maui.Graphics.Colors.Transparent.To_Android());
            });
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Aplicar tema guardado al iniciar
            bool esOscuro = ConfiguracionApp.ObtenerTema();
            UserAppTheme = esOscuro ? AppTheme.Dark : AppTheme.Light;

            return new Window(new AppShell());
        }
    }
}
