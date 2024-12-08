namespace DeKoelkast.Pages;

public partial class BillPostponePage : ContentPage
{
	public BillPostponePage()
	{
		InitializeComponent();
	}
    private async void OnOkButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainMenuPage());
    }
}