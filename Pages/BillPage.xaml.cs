namespace DeKoelkast.Pages;

public partial class BillPage : ContentPage
{
	public BillPage()
	{
		InitializeComponent();
	}
    private async void OnUitstellenButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BillPostponePage());
    }

    private async void OnOkButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaymentPage());
    }
}