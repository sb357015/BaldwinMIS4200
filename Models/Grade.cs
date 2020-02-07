using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaldwinMIS4200.Models
{
    public class Grade
    {
        public int gradeID { get; set; }
        public string description { get; set; }
        public decimal percentageGrade { get; set; }

        public ICollection<CourseDetail> CourseDetail { get; set; }

        public int instructorID { get; set; }
    }
}