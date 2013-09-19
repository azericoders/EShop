using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace EShop.Web.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(15)]
        [DisplayName("İstifadəçi adı")]
        public string LoginName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(255)]
        [DisplayName("Şifrə")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [DisplayName("Şifrəni təsdiqləyin")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(255)]
        public string Email { get; set; }
    }
}