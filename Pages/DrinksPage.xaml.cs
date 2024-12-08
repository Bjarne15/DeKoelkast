namespace DeKoelkast.Pages;
using DeKoelkast.Models;
using DeKoelkast.Helpers;

public partial class DrinksPage : ContentPage
{
    public Dictionary<string, int> Drinks { get; set; }

    public DrinksPage()
    {
        InitializeComponent();

        if (AppState.SelectedFridge != null)
        {
            var fridge = AppState.SelectedFridge;
            Drinks = fridge.Inventory;
        }

        BindingContext = this;
    }

    private void OnDrinkSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is KeyValuePair<string, int> selectedDrink)
        {
            if (selectedDrink.Value > 0)
            {
                Drinks[selectedDrink.Key]--;

                Navigation.PushAsync(new DrinksConfirmationPage($"1 x {selectedDrink.Key} werd uit de koelkast gehaald en op jouw rekening gezet"));
            }
            else
            {
                DisplayAlert("Fout", "Geen voorraad meer", "OK");
            }
        }
    }
}