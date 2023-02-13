using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Hosting;
using System.Text.Json.Serialization;

namespace CrediatSearchApi.Models
{
    public class Bank
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public virtual List<Credit> Credits { get; set; }

    }
}
