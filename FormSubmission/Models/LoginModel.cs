using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username should not be empty!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password should not be empty!")]
        public string Password { get; set; }
    }
}
