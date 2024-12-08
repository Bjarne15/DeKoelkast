using DeKoelkast.Pages;

namespace DeKoelkast.Pages;

public partial class GroceryPage : ContentPage
{
	public GroceryPage()
	{
		InitializeComponent();
	}

	private async void OnOkButtonClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainMenuPage());
	}
}