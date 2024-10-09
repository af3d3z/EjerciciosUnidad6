namespace Ejercicio01Unidad6;

public partial class Ejercicio2 : ContentPage
{
	public Ejercicio2()
	{
		InitializeComponent();
	}

    private async void BtnEj3_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Ejercicio2P2());
    }
}