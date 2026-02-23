namespace ASPSchoolZlatomir.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime RegisterOn { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
