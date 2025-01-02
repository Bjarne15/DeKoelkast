using SQLite;

public class Inventory
{
    [PrimaryKey, AutoIncrement]
    public int InventoryId { get; set; }
    public int FridgeId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public double PricePerUnit { get; set; } // Optionele prijs per eenheid in deze koelkast

    public Inventory() { }
}
