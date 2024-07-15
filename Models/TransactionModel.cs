using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jqueryAjaxCrud.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }

        [Required(ErrorMessage = "Account Number is required.")]
        [StringLength(12, ErrorMessage = "Account Number cannot be longer than 12 characters.")]
        [Display(Name = "Account Number")]
        [Column(TypeName = "nvarchar(12)")]
        public string AccountNumber { get; set; }

        [Required(ErrorMessage = "Beneficiary Name is required.")]
        [StringLength(100, ErrorMessage = "Beneficiary Name cannot be longer than 100 characters.")]
        [Display(Name = "Beneficiary Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string BeneficiaryName { get; set; }

        [Required(ErrorMessage = "Bank Name is required.")]
        [StringLength(100, ErrorMessage = "Bank Name cannot be longer than 100 characters.")]
        [Display(Name = "Bank Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }

        [Required(ErrorMessage = "SWIFT Code is required.")]
        [StringLength(11, MinimumLength = 8, ErrorMessage = "SWIFT Code must be between 8 and 11 characters.")]
        [Display(Name = "SWIFT Code")]
        [Column(TypeName = "nvarchar(11)")]
        public string SWIFTCode { get; set; }

        [Required(ErrorMessage = "Amount is required.")]
        [Display(Name = "Amount")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }

    }
}
