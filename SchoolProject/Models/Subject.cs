namespace SchoolProject.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<StudentSubject> StudentSubjects { get; set; } = new();
    }
}
