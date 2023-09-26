namespace FruitApp;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

	private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
		Navigation.PopModalAsync();
	}


}