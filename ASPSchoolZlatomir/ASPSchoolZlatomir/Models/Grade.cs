namespace ASPSchoolZlatomir.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public int StudentId { get; set; }
        public Student Students { get; set; }
        public int SubjectId { get; set; }
        public Subject Subjects { get; set; }
        public DateTime RegisterOn { get; set; }
    }
}
