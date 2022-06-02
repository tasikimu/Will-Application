using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Will_Generator.Models
{
    public class PersonalDetail
    {
        [Key]
        public int ID { get; set; }
        public string IdentificationNo { get; set; }
        public string Title { get; set; }
        public string Fullnames { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Cellphone { get; set; }
        public string PostalAddress { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal EstateValue { get; set; }

        public string MaritalStatus { get; set; }

                            /* Additional Information */
        public string BurialPreference { get; set; }

        [MaxLength(20000)]
        public string LastWishes { get; set; }

        public int NumberOfChildren { get; set; }

        public string EstateInheriter { get; set; }

        public string EstateOtherInheriter { get; set; }
    }
}