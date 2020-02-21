using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace BaldwinMIS4200.Models
{
	public class Course
	{

		public int courseID { get; set; }
		[Display(Name = "Description")]
		[Required(ErrorMessage = " Description required")]
		[StringLength(25)]
		public string description { get; set; }
		[Display(Name = "Course Date")]
		
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
		public Nullable<System.DateTime> courseDate { get; set; }

		public ICollection<CourseDetail> CourseDetail { get; set; }

		public int studentID { get; set; }
		public virtual Student Student { get; set; }
	}
}