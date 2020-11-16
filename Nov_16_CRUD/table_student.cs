namespace MvcCRUD.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class tbl_student
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Fname { get; set; }
        [Required(ErrorMessage = "Required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required")]
        [MinLength(11,ErrorMessage ="Mobile number should be 11 digit")]
        public string Mobile { get; set; }
        public string Description { get; set; }
    }
}