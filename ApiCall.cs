using Student_Enroll_Console.Model;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Student_Enroll_Console
{
    public class ApiCall
    {
        public async Task PostDataAsync(string endpoint, object data)
        {
            using(HttpClient client = new HttpClient())
            {
                var json = JsonSerializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(endpoint,content);

                if(response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Created Successfully!");
                }
                else
                {
                    var errorContent = await response.Content.ReadFromJsonAsync<Error>();
                    Console.WriteLine($"Error: {response.StatusCode} - {errorContent.error_message.errors[0].errorMessage}");
                }
            }
        }

        public async Task<string?> GetAllDataAsync(string endpoint)
        {
            using(HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(endpoint);

                if(response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return result;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode} - {errorContent}");
                }
                return null;
            }
        }

        public async Task<string?> GetDataAsync(string endpoint, int id)
        {
            using(HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"{endpoint}/{id}");

                if(response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return result;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode} - {errorContent}");
                }
                return null;
            }
        }

        public async Task PutDataAsync(string endpoint, object data)
        {
            using(HttpClient client = new HttpClient())
            {
                var json = JsonSerializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(endpoint,content);

                if(response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Updated Successfully!");
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode} - {errorContent}");
                }
            }
        }

        public async Task DeleteDataAsync(string endpoint,int id)
        {
            using(HttpClient client = new HttpClient())
            {
                var response = await client.DeleteAsync($"{endpoint}/{id}");

                if(response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Deleted Successfully!");
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode} - {errorContent}");
                }
            }
        }
    }
}