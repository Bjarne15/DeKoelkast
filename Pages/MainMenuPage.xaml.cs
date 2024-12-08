
namespace DeKoelkast.Pages;

public partial class MainMenuPage : ContentPage
{
	public MainMenuPage()
	{
		InitializeComponent();
	}
    private async void OnDrinkButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DrinksPage());
    }

    private async void OnAddDrinkButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddDrinkPage());
    }

    private async void OnCheckoutButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BillPage());
    }

    private async void OnLogoutButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StartMenuPage());
    }
}