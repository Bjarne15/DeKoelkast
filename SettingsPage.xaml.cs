namespace DeKoelkast;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

	private async void OnBackButtonClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new HomeMenuPage());
	}
}