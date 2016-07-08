using SQLite;

namespace BusinessLibrary.Models
{
    [Table("Employeer")]
    public class Employeer
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }        
    }
}
