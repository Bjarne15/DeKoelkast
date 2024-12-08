using DeKoelkast.Pages;

namespace DeKoelkast.Pages;

public partial class DrinkInventoryLowPage : ContentPage
{
	public DrinkInventoryLowPage()
	{
		InitializeComponent();
	}

	private async void OnOkButtonClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainMenuPage());
	}
}