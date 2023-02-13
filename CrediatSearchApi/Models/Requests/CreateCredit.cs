using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrediatSearchApi.Models.Requests
{
    public class CreateCredit
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Int64 MinimumAmount { get; set; }
        
        [Required]
        public string? CreditDescription { get; set; }
        
        [Required]
        public int InitialFee { get; set; }
        
        [Required]
        public int BankId { get; set; }
    }
}
