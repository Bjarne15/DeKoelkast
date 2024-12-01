using DeKoelkast.Pages;
namespace DeKoelkast;

public partial class StartMenuPage : ContentPage
{
	public StartMenuPage()
	{
		InitializeComponent();
	}

	private async void OnCreateAccountButtonClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Pages.CreateAccountPage());
	}

	private async void OnLoginButtonClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Pages.LoginPage());
	}
}