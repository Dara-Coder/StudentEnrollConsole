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
                Console.WriteLine($"Enroll ID: {student.id}\tStudent Name: {student.newStudent.name}\tStudent Subject: {student.subject.name}\tStudent Section: {student.section.name}\tUpdate At: {student.updated_at}");
            }
        }

        public async Task GetEnrollStudent(int id)
        {
            var result = await api.GetDataAsync(baseUri+"api/EnrollStudent",id);
            EnrollStudent? student = JsonSerializer.Deserialize<EnrollStudent>(result);
            Console.WriteLine($"Enroll ID: {student.id}\tStudent Name: {student.newStudent.name}\tStudent Subject: {student.subject.name}\tStudent Section: {student.section.name}\tUpdate At: {student.updated_at}");
        }

        public async Task UpdateEnrollStudent(EnrollStudent enrollStudent)
        {
            enrollStudent.created_at = DateTime.Now;
            enrollStudent.updated_at = DateTime.Now;
            await api.PutDataAsync(baseUri+"api/EnrollStudent",enrollStudent);
        }

        public async Task DeleteEnrollStudent(int id)
        {
            await api.DeleteDataAsync(baseUri+"api/EnrollStudent",id);
        }
    }
}