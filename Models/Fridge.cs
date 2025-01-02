using SQLite;

namespace DeKoelkast.Models
{
    public class Fridge
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Unique, NotNull]
        public string Name { get; set; }

        public string Location { get; set; }
    }
}
