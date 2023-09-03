using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank_Transactions.Models
{
    public class Transaction
    {
        [Key]
       public int TransactionId { get; set; }
        [Column(TypeName ="nvarchar(12)")]
        [DisplayName(" Account Number")]
        [Required(ErrorMessage = "This field is required")]
        public string   AccountNumber { get; set; }
		[Column(TypeName = "nvarchar(12)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This field is required")]
        public string BeneficiaryName { get; set; }
		[Column(TypeName = "nvarchar(12)")]
        [DisplayName("Banke Name")]
        [Required(ErrorMessage = "This field is required")]
        public string BankeName { get; set; }
		[Column(TypeName = "nvarchar(12)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This field is required")]
        public string SWIFTCode { get; set; }
        [Required(ErrorMessage ="This field is required")]
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }
    }
}
