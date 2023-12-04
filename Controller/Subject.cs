using System.Text.Json;
using Student_Enroll_Console.Model;

namespace Student_Enroll_Console.Controller
{
    public class SubjectController
    {
        ApiCall api = new ApiCall();
        Uri baseUri = new Uri("https://localhost:7130/");
        public async Task SetSubjectAsync(Subject subject)
        {
            subject.created_at = DateTime.Now;
            subject.updated_at = DateTime.Now;
            await api.PostData(baseUri+"api/Subject",subject);
        }

        public async Task GetAllSubjectAsync()
        {
            var result = await api.GetAllDataAsync(baseUri+"api/Subject");
            List<Subject>? data = JsonSerializer.Deserialize<List<Subject>>(result);
            foreach(var subject in data)
            {
                Console.WriteLine($"Code: {subject.code}\tName: {subject.name}\tFee: {subject.fee}\tUpdate At: {subject.updated_at}");
            }
        }
    }
}