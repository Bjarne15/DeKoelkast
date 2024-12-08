namespace DeKoelkast.Pages;
using DeKoelkast.Models;

public partial class FridgeInventoryPage : ContentPage
{
	public Fridge SelectedFridge { get; set; }

	public FridgeInventoryPage(Fridge fridge)
	{
		InitializeComponent();
		SelectedFridge = fridge;
		BindingContext = SelectedFridge;
	}
}