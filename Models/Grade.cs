using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BaldwinMIS4200.Models
{
    public class Grade
    {
        public int gradeID { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = " Description required")]
        [StringLength(25)]
        public string description { get; set; }
        [Display(Name = " Percentage Grade")]
        [Required(ErrorMessage = " Grade required")]

        public decimal percentageGrade { get; set; }

        public ICollection<CourseDetail> CourseDetail { get; set; }

        public int instructorID { get; set; }
    }
}