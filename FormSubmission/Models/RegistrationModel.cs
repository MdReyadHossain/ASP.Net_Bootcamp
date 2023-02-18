using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FormSubmission.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Name should not be empty!")]
        [StringLength(10, ErrorMessage = "Name should not be exceed 10 characters!")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Please select your gender!")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please select your Profession!")]
        public string Profession { get; set; }

        [Required(ErrorMessage = "Please select your hobbies!")]
        public string[] Hobbies { get; set; }

        [Required(ErrorMessage = "Please provide your date of birth!")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Password should not be empty!")]
        [MinLength(6, ErrorMessage = "Password should be minimum 6 characters")]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Retype your password again!")]
        [Compare("Password", ErrorMessage = "Password does not matched!")]
        public string RePassword { get; set; }
    }
}