using System.Text;
using System.Text.Json;

namespace Student_Enroll_Console
{
    public class ApiCall
    {
        private HttpClient _client;

        public ApiCall()
        {
            _client = new HttpClient();
        }

        public async Task PostData(string endpoint, object data)
        {
            var url = new Uri(endpoint);
            var dataJson = JsonSerializer.Serialize(data);
            var content = new StringContent(dataJson, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync(url, content);

            if(response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine("POST request successful. Response: " + result);
            }
            else
            {
                Console.WriteLine("POST request failed");
            }
        }

        public async Task GetData(string endpoint)
        {
            var response = await _client.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine("GET request successful. Response: " + result);
            }
            else
            {
                Console.WriteLine("GET request failed");
            }
        }

        public async Task PutData(string endpoint, object data)
        {
            var dataJson = JsonSerializer.Serialize(data);
            var content = new StringContent(dataJson, Encoding.UTF8, "application/json");

            var response = await _client.PutAsync(endpoint, content);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine("PUT request successful. Response: " + result);
            }
            else
            {
                Console.WriteLine("PUT request failed");
            }
        }

        public async Task DeleteData(string endpoint)
        {
            var response = await _client.DeleteAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine("DELETE request successful. Response: " + result);
            }
            else
            {
                Console.WriteLine("DELETE request failed");
            }
        }
    }
}