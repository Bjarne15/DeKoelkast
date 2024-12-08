using DeKoelkast.Models;
using Microsoft.Extensions.Logging;

namespace DeKoelkast
{
    public static class MauiProgram
    {
        public static List<Fridge> Fridges = new List<Fridge>
        {
            new Fridge
            {
                Name = "Zuyd Heerlen",
                Inventory = new Dictionary<string, int>
                {
                    { "Cola", 10 },
                    { "Sprite", 8 },
                    { "Fanta", 12 },
                    { "Monster Energy", 5 },
                    { "Red Bull", 6 },
                    { "Bier", 15 }
                }
            },
            new Fridge
            {
                Name = "Zuyd Maastricht",
                Inventory = new Dictionary<string, int>
                {
                    { "Cola", 20 },
                    { "Sprite", 10 },
                    { "Fanta", 5 },
                    { "Monster Energy", 8 },
                    { "Red Bull", 4 },
                    { "Bier", 18 }
                }
            },
            new Fridge
            {
                Name = "Zuyd Sittard",
                Inventory = new Dictionary<string, int>
                {
                    { "Cola", 15 },
                    { "Sprite", 12 },
                    { "Fanta", 10 },
                    { "Monster Energy", 7 },
                    { "Red Bull", 3 },
                    { "Bier", 20 }
                }
            }
        };
        public static List<User> Users = new List<User>
        {
            new User { UserName = "admin", Password = "admin123", FullName = "Administrator" },
            new User { UserName = "user1", Password = "password1", FullName = "Bjarne van Asch" },
            new User { UserName = "user2", Password = "password2", FullName = "Piet Smiet" }
        };
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
