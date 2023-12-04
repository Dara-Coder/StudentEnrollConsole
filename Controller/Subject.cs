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
            await api.PostDataAsync(baseUri+"api/Subject",subject);
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

        public async Task GetSubjectAsync(int id)
        {
            var result = await api.GetDataAsync(baseUri+"api/Subject",id);
            Subject? subject = JsonSerializer.Deserialize<Subject>(result);
            Console.WriteLine($"Code: {subject.code}\tName: {subject.name}\tFee: {subject.fee}\tUpdate At: {subject.updated_at}");
        }

        public async Task UpdateSubjectAsync(Subject subject)
        {
            subject.created_at = DateTime.Now;
            subject.updated_at = DateTime.Now;
            await api.PutDataAsync(baseUri+"api/Subject",subject);
        }

        public async Task DeleteSubjectAsync(int id)
        {
            await api.DeleteDataAsync(baseUri+"api/Subject",id);
        }
    }
}