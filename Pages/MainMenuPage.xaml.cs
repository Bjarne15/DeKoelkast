namespace DeKoelkast.Pages;
using DeKoelkast.Helpers;

public partial class MainMenuPage : ContentPage
{
    public MainMenuPage()
    {
        InitializeComponent();
        if (AppState.SelectedFridge != null)
        {
            var fridge = AppState.SelectedFridge;
            DisplayAlert("Gekozen Koelkast", $"Je hebt {fridge.Name} gekozen.", "OK");
        }
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