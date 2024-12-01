namespace DeKoelkast.Pages;

public partial class AddDrinkPage : ContentPage
{
	public AddDrinkPage()
	{
		InitializeComponent();
	}

	private async void OnAcceptButtonClicked(object sender, EventArgs e)
	{
		var drinkName = DrinkNameEntry.Text;
		var drinkPrice = DrinkPriceEntry.Text;
		var drinkQuantity = DrinkQuantityEntry.Text;
		await Navigation.PushAsync(new DrinkAddedConfirmationPage(drinkName, drinkPrice, drinkQuantity));
	}
}