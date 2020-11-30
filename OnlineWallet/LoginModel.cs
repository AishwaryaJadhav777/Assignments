using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Pro.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "*UserName Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "*Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}