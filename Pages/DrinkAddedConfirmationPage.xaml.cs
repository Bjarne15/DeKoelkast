namespace DeKoelkast.Pages;

public partial class DrinkAddedConfirmationPage : ContentPage
{
    public DrinkAddedConfirmationPage(string drinkName, string drinkPrice, string drinkQuantity)
    {
        InitializeComponent();
        ConfirmationLabel.Text = $"{drinkQuantity} flessen {drinkName} met prijs {drinkPrice}€ werd toegevoegd.";
    }

    private async void OnOkButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainMenuPage());
    }
}