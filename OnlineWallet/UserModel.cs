using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Pro.Models
{
    public class UserModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "*First Name is Required ")]
        [Display(Name = "User Name: ")]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "*Email Address Required ")]
        [Display(Name = "Email: ")]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$", ErrorMessage = "Please Provide Valid Email")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "*Password is Required ")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password must be 6 characters long.")]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "*Confirm-Password is Required ")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password: ")]
        [Compare("Password", ErrorMessage = "Password and cofirm Password does not matched")]
        public string ConfirmPassword { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="*Date_of_Bith Required")]
        [DataType(DataType.Date)]
        [Display(Name = "Date_of_Birth: ")]
        public DateTime Date_of_Birth { get; set; }

        [Required(ErrorMessage = "*Contact Required ")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact: ")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-.]?([0-9]{3})[-.]?([0-9]{4})$",ErrorMessage ="Entered phone format in not valid.")]
        public long Contact { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "*IFSC_Code Required ")]
        [Display(Name = "IFSC_Code: ")]
        public string IFSC_Code { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "*Account Number Required ")]
        [Display(Name = "Account_Number: ")]
        public string Account_Number { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "*Account Type Required ")]
        [Display(Name = "Account_Type: ")]
        public string Account_Type { get; set; }

        public string Message { get; set; }


    }
}