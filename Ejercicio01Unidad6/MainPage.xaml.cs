namespace Ejercicio01Unidad6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        bool btn3Creado = false;

        /// <summary>
        /// Evento que creará un botón al pulsar btn2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2OnClick(object sender, EventArgs e) {
            var btn3 = new Button
            {
                FontFamily = "Verdana",
                Text = "Boton3",
                FontAttributes = FontAttributes.Bold,
                BorderColor = Colors.Yellow,
                BorderWidth = 2,
                FontSize = 16,
                MaximumHeightRequest = 70,
                MaximumWidthRequest = 200,
                Margin = 5,
                BackgroundColor = Colors.Blue,
                VerticalOptions = LayoutOptions.Start
            };

            if (!btn3Creado)
            {
                btn3Creado = true;
                btn3.Clicked += btn3OnClick;
                VStackLayout.Add(btn3);
            }
            else {
                btnEj2.IsVisible = true;
            }
            
        }

        /// <summary>
        /// Evento al pulsar btn3 que cambia el texto de btn2 y quita btn1 del vertical stack layout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3OnClick(object sender, EventArgs e) {
            btn2.Text = "Crear controles en tiempo de ejecución mola";
            VStackLayout.Remove(btn1);
        }

        /// <summary>
        /// Cambia de pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnEj2Click(object sender, EventArgs e) { 
            await Navigation.PushAsync(new Ejercicio2());
        }
    }

}
