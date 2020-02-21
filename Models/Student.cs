using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BaldwinMIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }
        [Display(Name = "First name")]
        [Required(ErrorMessage = " First name required")]
        [StringLength(25)]
        public string firstName { get; set; }
        [Display(Name = "Last name")]
        [Required]
        [StringLength(25)]

        public string lastName { get; set; }
        [Display(Name = "Email address")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter your most frequently used email address")]
        public string email { get; set; }
        [Display (Name = "Mobile phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}-)\d{3}-\d{4}$",
            ErrorMessage ="Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }

        

        public ICollection<Course> Course { get; set; }
    }
}