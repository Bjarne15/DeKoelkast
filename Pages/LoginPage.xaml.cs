namespace DeKoelkast.Pages;
using DeKoelkast.Models;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    private void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string fullName = FullNameEntry.Text;
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        var user = MauiProgram.Users.FirstOrDefault(u =>
            u.UserName == username &&
            u.Password == password &&
            u.FullName == fullName);

        if (user != null)
        {
            DisplayAlert("Succes", $"Welkom, {user.FullName}!", "OK");
            Navigation.PushAsync(new FridgeSelectionPage());
        }
        else
        {
            DisplayAlert("Fout", "Ongeldige naam, gebruikersnaam of wachtwoord.", "OK");
        }
    }
}