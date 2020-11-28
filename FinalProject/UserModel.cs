using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineWallet.Models
{
    public class UserModel
    {
       

        [Required(AllowEmptyStrings =false,ErrorMessage ="*First Name is Required ")]
        [Display(Name ="First Name: ")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "*Last Name is Required ")]
        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "*Email Address Required ")]
        [Display(Name = "EmailID: ")]
        public string EmailID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "*Password is Required ")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "*Confirm-Password is Required ")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password: ")]
        [Compare("Password",ErrorMessage ="Password and cofirm Password does not matched")]
        public string ConfirmPassword { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "*Account Number Required ")]
        [Display(Name = "Account_Number: ")]
        public string Account_Number { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "*Account Type Required ")]
        [Display(Name = "Account_Type: ")]
        public string Account_Type { get; set; }


        public DateTime CreatedOn { get; set; }

        public string Message { get; set; }
    }
}