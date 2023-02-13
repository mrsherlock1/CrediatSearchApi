using System.ComponentModel.DataAnnotations;

namespace CrediatSearchApi.Models.Requests
{
    public class FilterCredits
    {
        [DataType("int")]
        public int? MinimumAmount { get; set; }
        [DataType("int")]
        public int? InitialFee { get; set; }

        [DataType("string")]
        public string? BankName { get; set; }
    }
}
