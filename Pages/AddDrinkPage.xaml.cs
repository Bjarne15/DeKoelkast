namespace DeKoelkast.Pages;
using DeKoelkast.Models;
using DeKoelkast.Helpers;

public partial class AddDrinkPage : ContentPage
{
    public List<string> Drinks { get; set; }

    public AddDrinkPage()
    {
        InitializeComponent();

        Drinks = new List<string> { "Cola", "Sprite", "Fanta", "Monster Energy", "Red Bull", "Bier" };
        BindingContext = this;
    }

    private void OnAddClicked(object sender, EventArgs e)
    {
        if (DrinkPicker.SelectedItem is string selectedDrink &&
            int.TryParse(QuantityEntry.Text, out int quantity) &&
            decimal.TryParse(PriceEntry.Text, out decimal price))
        {
            if (AppState.SelectedFridge != null)
            {
                var fridge = AppState.SelectedFridge;

                if (fridge.Inventory.ContainsKey(selectedDrink))
                    fridge.Inventory[selectedDrink] += quantity;
                else
                    fridge.Inventory[selectedDrink] = quantity;

                Navigation.PushAsync(new DrinksConfirmationPage(
                    $"{quantity} flessen {selectedDrink} met prijs {price:C} werd toegevoegd aan {fridge.Name}"
                ));
            }
            else
            {
                DisplayAlert("Fout", "Er is geen koelkast geselecteerd.", "OK");
            }
        }
        else
        {
            DisplayAlert("Fout", "Voer een geldige drank, hoeveelheid en prijs in.", "OK");
        }
    }
}