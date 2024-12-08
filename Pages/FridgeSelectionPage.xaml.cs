namespace DeKoelkast.Pages;
using DeKoelkast.Models;
using DeKoelkast.Helpers;

public partial class FridgeSelectionPage : ContentPage
{
	public List<Fridge> Fridges { get; set; }

	public FridgeSelectionPage()
	{
		InitializeComponent();
		Fridges = MauiProgram.Fridges;
		BindingContext = this;
	}

    private void OnFridgeSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Fridge selectedFridge)
        {
            AppState.SelectedFridge = selectedFridge;

            Navigation.PushAsync(new MainMenuPage());
        }
    }

    private async void OnSettingsPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SettingsPage());
    }
}