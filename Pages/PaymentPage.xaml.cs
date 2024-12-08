namespace DeKoelkast.Pages;

public partial class PaymentPage : ContentPage
{
	public PaymentPage()
	{
		InitializeComponent();
	}
    private async void OnPaymentOptionClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PayingPage());
    }
}