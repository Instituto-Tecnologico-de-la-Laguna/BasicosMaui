

namespace BasicosMaui
{
    public partial class MainPage : ContentPage
    {
   

        public MainPage()
        {
            InitializeComponent();
        }

        private void CambioNombre(object sender,TextChangedEventArgs e) 
        {
            Console.WriteLine($"Nombre actual:{e.NewTextValue}");
        }

        private void OnSwicthToggled(object sender,ToggledEventArgs e) 
        {
            string estado = e.Value ? "Activadas" : "Desactivadas";
            DisplayAlert("Switch", $"Notificaciones:{estado}", "Ok");
        }

        private void OnSliderChanged(object sender,ValueChangedEventArgs e)        
        {
            lblExperiencia.Text = $"Nivel: {(int)e.NewValue}";
        }

        private async void OnGuardarClick(object sender, EventArgs e)
        {
            string nombre = entradaNombre.Text ?? "Sin Nombre";
            string edad = entradaEdad.Text ?? "Sin Edad";
            bool notif = switchNotificaciones.IsToggled;
            int nivel = (int)slideExperiencia.Value;

            lblResultado.Text =
                $"Nombre:{nombre}\n" +
                $"Edad: {edad}\n" +
                $"Notificaciones: {(notif ? "Si" : "No")}\n" +
                $"Nivel de Experiencia: {nivel}/10";

            await DisplayAlert("¡Guardado!", "Datos registrados correctamente","Ok");

        }


    }
}
