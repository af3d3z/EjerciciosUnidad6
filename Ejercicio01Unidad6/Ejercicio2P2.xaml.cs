namespace Ejercicio01Unidad6;

public partial class Ejercicio2P2 : ContentPage
{
	public Ejercicio2P2()
	{
        InitializeComponent();
    }

    void switcher_Toggled(object sender, ToggledEventArgs e)
    {
        bool toggled = swtModo.IsToggled;
       

        if (toggled)
        {
            lblModo.Text = "Modo Claro";
            vslSwitch.BackgroundColor = Colors.White;
            lblModo.TextColor = Colors.Black;
        }
        else
        {
            lblModo.Text = "Modo Oscuro";
            vslSwitch.BackgroundColor = Colors.Black;
            lblModo.TextColor = Colors.White;
        }
    }
}