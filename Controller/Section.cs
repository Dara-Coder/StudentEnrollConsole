using System.Text.Json;
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
            List<Section>? data = JsonSerializer.Deserialize<List<Section>>(result);
            foreach(var section in data)
            {
                Console.WriteLine($"ID: {section.id}\tCode: {section.code}\tName: {section.name}\tCheckin Time: {section.checkin_time}\tCheckout Time: {section.checkout_time}");
            }
        }

        public async Task GetSectionAsync(int id)
        {
            var result = await api.GetDataAsync(baseUri+"api/Section",id);
            Section? section = JsonSerializer.Deserialize<Section>(result);
            Console.WriteLine($"ID: {section.id}\tCode: {section.code}\tName: {section.name}\tCheckin Time: {section.checkin_time}\tCheckout Time: {section.checkout_time}");
        }

        public async Task UpdateSectionAsync(Section section)
        {
            await api.PutDataAsync(baseUri+"api/Section",section);
        }

        public async Task DeleteSectionAsync(int id)
        {
            await api.DeleteDataAsync(baseUri+"api/Section",id);
        }
    }
}