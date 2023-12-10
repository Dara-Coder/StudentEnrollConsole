namespace Student_Enroll_Console.Model
{
    public class EnrollStudent
    {
        public int id { get; set; }
        public int newStudentId { get; set; }
        public int sectionId { get; set; }
        public int subjectId { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public NewStudent? newStudent { get; set; }
        public Section? section { get; set; }
        public Subject? subject { get; set; }
    }
}