namespace Student_Enroll_Console.Model
{
    public class NewStudent
    {
        public int id { get; set; }
        public string? code { get; set; }
        public string? name { get; set; }
        public string? sex { get; set; }
        public DateTime date_of_birth { get; set; }
        public string? phone_number { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}