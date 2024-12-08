namespace DeKoelkast.Pages;

public partial class DrinksPage : ContentPage
{
	public DrinksPage()
	{
		InitializeComponent();
	}
    private async void OnDrinkButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var drink = button.Text;
        await Navigation.PushAsync(new DrinksConfirmationPage(drink));
    }
}