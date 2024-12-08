using DeKoelkast.Data;

namespace DeKoelkast.Pages
{
    public partial class InventoryPage : ContentPage
    {
        public InventoryPage()
        {
            InitializeComponent();
            inventoryListView.ItemsSource = FridgeManager.SelectedFridge.Inventory;
        }
    }
}