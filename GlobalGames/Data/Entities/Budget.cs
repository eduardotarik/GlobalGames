using System.ComponentModel.DataAnnotations;

namespace GlobalGames.Data.Entities
{
    public class Budget : IEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string Descricao { get; set; }
    }
}
