using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaldwinMIS4200.Models;
using System.Data.Entity;

namespace BaldwinMIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }

    }

}
