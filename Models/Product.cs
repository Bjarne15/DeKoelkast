using SQLite;

public class Product
{
    [PrimaryKey, AutoIncrement]
    public int ProductId { get; set; }
    public string Category { get; set; } // Bijvoorbeeld "Bier", "Frisdrank", etc.
    public string ProductName { get; set; } // Naam van het product, bijv. "Cola"
    public double DefaultPrice { get; set; } // Standaardprijs per eenheid
}
