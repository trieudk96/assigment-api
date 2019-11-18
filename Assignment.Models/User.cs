using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Assignment.Common.Models;

namespace Assignment.Models
{
    [Table("USER_ASSIGNMENT")]
    public class User : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [Column("MOBILE")]
        [MaxLength(20)]
        public string MobileNumber { get; set; }
        public int Gender { get; set; }
        [MaxLength(100)]
        public string Dob { get; set; }
        [Column("EMAIL_OTP_IN")]
        [MaxLength(100)]
        public string EmailOtpIn { get; set; }
        [Column("IS_DELETED")]
        public new bool IsDeleted { get; set; }

    }

}
