using Student_Enroll_Console.Model;

namespace Student_Enroll_Console.Controller
{
    public class EnrollStudentController
    {
        ApiCall api = new ApiCall();
        Uri baseUri = new Uri("https://localhost:7130/");
        public async Task SetEnrollStudent(EnrollStudent enrollStudent)
        {
            enrollStudent.created_at = DateTime.Now;
            enrollStudent.updated_at = DateTime.Now;
            await api.PostDataAsync(baseUri+"api/EnrollStudent",enrollStudent);
        }
    }
}