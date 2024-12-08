namespace DeKoelkast.Pages;
using DeKoelkast.Models;
using DeKoelkast.Helpers;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
        InitializeComponent();
	}

	

    private async void OnLogoutClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new StartMenuPage());
    }

    private async void OnBackToFridgeSelectionClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FridgeSelectionPage());
    }
}