using Student_Enroll_Console.Model;

namespace Student_Enroll_Console.Controller
{
    public class SectionController
    {
        ApiCall api = new ApiCall();
        Uri baseUri = new Uri("https://localhost:7130/");
        public async Task SetSectionAsync(Section section)
        {
            await api.PostDataAsync(baseUri+"api/Section",section);
        }

        public async Task GetAllSectionAsync()
        {
            var result = await api.GetAllDataAsync(baseUri+"api/Section");
        }
    }
}