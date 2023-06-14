using Azure.Storage.Blobs.Models;
using System.ComponentModel.DataAnnotations;

namespace GlobalGames.Data.Entities
{
    public class Subscriber : IEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        public User User { get; set; }

    }
}
