using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace BaldwinMIS4200.Models
{
	public class Course
	{
		
		public int courseID { get; set; }
		public string description { get; set; }
		public DateTime courseDate { get; set; }

		public ICollection<CourseDetail> CourseDetail { get; set; }

		public int studentID { get; set; }
		public virtual Student Student { get; set; }
	}
}