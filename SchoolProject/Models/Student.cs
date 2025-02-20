namespace SchoolProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<StudentSubject> StudentSubjects { get; set; } = new();
    }
}
