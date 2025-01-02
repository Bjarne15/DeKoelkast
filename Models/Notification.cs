using SQLite;
using System;

public class Notification
{
    [PrimaryKey, AutoIncrement]
    public int NotificationId { get; set; }
    public int FridgeId { get; set; }
    public int ProductId { get; set; }
    public string Message { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
