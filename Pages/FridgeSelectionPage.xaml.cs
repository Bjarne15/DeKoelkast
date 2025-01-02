using DeKoelkast.Services;
using DeKoelkast.Models;
using System.Collections.ObjectModel;

public partial class FridgeSelectionPage : ContentPage
{
    public ObservableCollection<Fridge> Fridges { get; set; }

    public FridgeSelectionPage()
    {
        InitializeComponent();

        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "DeKoelkast.db");
        var dbService = new DatabaseService(dbPath);

        Fridges = new ObservableCollection<Fridge>(dbService.GetFridges());
        BindingContext = this;
    }
}
