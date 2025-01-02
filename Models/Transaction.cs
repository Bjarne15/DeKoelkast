using SQLite;
using System;

public class Transaction
{
    [PrimaryKey, AutoIncrement]
    public int TransactionId { get; set; }
    public int UserId { get; set; }
    public int FridgeId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public double TotalPrice { get; set; }
    public DateTime TransactionDate { get; set; } = DateTime.Now;
}
