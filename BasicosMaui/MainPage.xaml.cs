

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


    }
}
