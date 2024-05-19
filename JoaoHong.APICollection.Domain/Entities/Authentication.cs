using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoaoHong.APICollection.Domain.Entities
{
    [Table("Authentication")]
    public class Authentication
    {
        [Key]
        [Column("AuthenticationId")]
        public long AuthenticationId { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Password")]
        public string Password { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; } = DateTime.Now; 
    }
}
