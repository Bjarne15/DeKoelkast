using DeKoelkast.DAL;

namespace DeKoelkast.Pages;

public partial class LoginPage : ContentPage
{
    private readonly UserRepository _userRepository;

    public LoginPage()
    {
        InitializeComponent();
        _userRepository = new UserRepository();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlert("Fout", "Gebruikersnaam en wachtwoord zijn verplicht!", "OK");
            return;
        }

        // Inloggegevens verifiëren
        bool isValid = await _userRepository.VerifyLoginAsync(username, password);
        if (isValid)
        {
            await DisplayAlert("Succes", "Inloggen geslaagd!", "OK");
            // Navigeren naar volgende pagina
        }
        else
        {
            await DisplayAlert("Fout", "Onjuiste inloggegevens!", "OK");
        }
    }
}