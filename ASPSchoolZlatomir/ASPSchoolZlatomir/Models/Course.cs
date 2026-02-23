namespace ASPSchoolZlatomir.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }

        public Teacher Teachers { get; set; }
        public Subject Subjects { get; set; }
    }
}
