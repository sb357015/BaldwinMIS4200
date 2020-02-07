namespace BaldwinMIS4200.Models
{
    public class CourseDetail
    {
        public int coursedetailID { get; set; }
        
        // the next two properties link the orderDetail to the Order
        public int courseID { get; set; }
        public virtual Course Course { get; set; }
        // the next two properties link the orderDetail to the Product
        public int gradeID { get; set; }
        public virtual Grade Grade { get; set; }

    }
}