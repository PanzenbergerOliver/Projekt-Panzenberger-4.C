using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PanzenbergerOliver_GameCSFD.Entities
{
    [Table("games")]

    public class Game
    {
        [Key]
        [Column("game_name")]
        public string GameName { get; set; }
        [Column("rating")]
        public double Rating { get; set; }
        [Column("player_name")]
        public string PlayerName { get; set; }
        [Column("played_time")]
        public double PlayedTime { get; set; }
        [Column("comment")]
        public string Comment { get; set; }
        [Column("Id")]
        public int Id { get; set; }
    }

}
