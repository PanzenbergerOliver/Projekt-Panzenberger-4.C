using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PanzenbergerOliver_GameCSFD.Entities
{
    [Table("gamess")]

    public class Gamess
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }
        [Column("name")]
        public double Name { get; set; }
        public List<Game> Games { get; set; } = new List<Game>();
    }
}
