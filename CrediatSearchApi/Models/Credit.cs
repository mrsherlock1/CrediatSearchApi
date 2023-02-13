using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CrediatSearchApi.Models
{
    public class Credit
    {
        [Key][Column("id")]
        public long Id { get; set; }

        [Required]
        public string Name { get; set;}
       

        [Required]
        [Column("minimum_amount")]
        public Int64? MinimumAmount { get; set; }

        [Column("description")]
        public string? CreditDescription { get; set; }

        [Required]
        [Column("inital_fee")]
        public int? InitialFee { get; set; }

        [Required]
        public int? BankId { get; set; }

        [JsonIgnore]
        public virtual Bank? Bank { get; set; }
    }
}
