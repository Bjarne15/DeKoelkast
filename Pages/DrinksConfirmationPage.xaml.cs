
namespace DeKoelkast.Pages;

public partial class DrinksConfirmationPage : ContentPage
{
	public DrinksConfirmationPage(string drink)
    {
		InitializeComponent();
        ConfirmationLabel.Text = $"1x {drink} werd uit de koelkast gehaald en op jouw rekening gezet.";
    }
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        if (Navigation.NavigationStack.Count == 1)
        {
            Navigation.PushAsync(new MainMenuPage());
        }
    }
    private async void OnOkButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainMenuPage());
    }
}