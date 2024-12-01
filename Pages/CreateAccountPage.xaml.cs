namespace DeKoelkast.Pages;

public partial class CreateAccountPage : ContentPage
{
    public CreateAccountPage()
    {
        InitializeComponent();
    }

        private async void OnRegisterButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainMenuPage());
    }

}
