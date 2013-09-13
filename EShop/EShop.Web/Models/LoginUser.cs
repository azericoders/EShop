using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EShop.Web.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Zəhmət olmazsa istifadəçi adını daxil edin.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Zəhmət olmazsa şifrəni adını daxil edin.")]
        public string Password { get; set; }
    }
}