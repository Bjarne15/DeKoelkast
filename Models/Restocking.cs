using SQLite;
using System;

public class Restocking
{
    [PrimaryKey, AutoIncrement]
    public int RestockId { get; set; }
    public int FridgeId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public double Cost { get; set; }
    public DateTime RestockDate { get; set; } = DateTime.Now;
}
