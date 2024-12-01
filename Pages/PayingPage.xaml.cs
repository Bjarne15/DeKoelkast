namespace DeKoelkast.Pages;

public partial class PayingPage : ContentPage
{
	public PayingPage()
	{
		InitializeComponent();
	}
    private async void OnOkButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainMenuPage());
    }

}