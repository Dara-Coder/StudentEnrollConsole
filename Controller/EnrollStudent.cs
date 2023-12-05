using System.Text.Json;
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

        public async Task GetAllEnrollStudent()
        {
            var result = await api.GetAllDataAsync(baseUri+"api/EnrollStudent");
            List<EnrollStudent>? data = JsonSerializer.Deserialize<List<EnrollStudent>>(result);
            foreach(var student in data)
            {
                Console.WriteLine($"Student ID: {student.newStudentId}\tStudent Subject ID: {student.subjectId}\tStudent Section ID: {student.sectionId}");
            }
        }

        public async Task GetEnrollStudent(int id)
        {
            var result = await api.GetDataAsync(baseUri+"api/EnrollStudent",id);
            EnrollStudent? student = JsonSerializer.Deserialize<EnrollStudent>(result);
            Console.WriteLine($"Student ID: {student.newStudentId}\tStudent Subject ID: {student.subjectId}\tStudent Section ID: {student.sectionId}");
        }

        public async Task UpdateEnrollStudent(EnrollStudent enrollStudent)
        {
            enrollStudent.created_at = DateTime.Now;
            enrollStudent.updated_at = DateTime.Now;
            await api.PutDataAsync(baseUri+"api/EnrollStudent",enrollStudent);
        }
    }
}