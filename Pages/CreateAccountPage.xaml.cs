using DeKoelkast.DAL;

namespace DeKoelkast.Pages;

public partial class CreateAccountPage : ContentPage
{
    private readonly UserRepository _userRepository;
    public CreateAccountPage()
    {
        InitializeComponent();
        _userRepository = new UserRepository();
    }
    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string realName = RealNameEntry.Text;
        string password = PasswordEntry.Text;

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(realName) || string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlert("Fout", "Alle velden zijn verplicht!", "OK");
            return;
        }

        // Check of gebruiker al bestaat
        var existingUser = await _userRepository.GetUserByUsernameAsync(username);
        if (existingUser != null)
        {
            await DisplayAlert("Fout", "Gebruikersnaam bestaat al!", "OK");
            return;
        }

        // Wachtwoord hashen en gebruiker opslaan
        var newUser = new User
        {
            Username = username,
            RealName = realName,
            PasswordHash = PasswordHelper.HashPassword(password)
        };

        await _userRepository.AddUserAsync(newUser);
        await DisplayAlert("Succes", "Gebruiker geregistreerd!", "OK");
        await Navigation.PushAsync(new MainMenuPage());
    }
}
