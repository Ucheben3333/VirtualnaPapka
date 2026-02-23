namespace ASPSchoolZlatomir.Models
{
    public class Subject
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime RegisterOn { get; set; }
        public ICollection<Grade> Grades { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}
