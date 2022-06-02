using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Will_Generator.Models
{
    public class EstateExecutor
    {
                                /*Banking Details Page*/
        [Key]
        public int ID { get; set; }
        public string IdentificationNo { get; set; }
        public string Title { get; set; }
        public string Fullnames { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string AccountType { get; set; }
        public string AccountNumber { get; set; }
        public string PrefferedPaymentDate { get; set; }
    }
}
