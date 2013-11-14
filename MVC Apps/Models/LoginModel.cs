using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Apps.Models
{
    public  class LoginModel
    {
        [Required(ErrorMessage = "This Username is required")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "The Password is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The Password is invalid")]
        [DataType(DataType.Password)]
        [Display(Name = "Pass word")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

    }
}