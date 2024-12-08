namespace DeKoelkast.Pages;

public partial class DrinkAddedConfirmationPage : ContentPage
{
    public string Message { get; set; }

    public DrinkAddedConfirmationPage(string message)
    {
        InitializeComponent();
        Message = message;
        BindingContext = this;
    }

    private void OnOkClicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync(); // Keer terug naar MainMenuPage
    }
}