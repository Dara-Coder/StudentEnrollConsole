namespace Student_Enroll_Console.Model
{
    public class Subject
    {
        public int id { get; set; }
        public string? code { get; set; }
        public string? name { get; set; }
        public float fee { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}