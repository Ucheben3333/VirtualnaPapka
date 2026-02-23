namespace ASPSchoolZlatomir.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime RegisterOn { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
