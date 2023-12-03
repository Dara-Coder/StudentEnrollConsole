using System.Text;
using System.Text.Json;
using Student_Enroll_Console.Model;

namespace Student_Enroll_Console
{
    public class ApiCall
    {
        public async Task PostData(string endpoint, object data)
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
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode} - {errorContent}");
                }
            }
        }

        public async Task GetAllDataAsync(string endpoint)
        {
            using(HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(endpoint);

                if(response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    List<NewStudent>? data = JsonSerializer.Deserialize<List<NewStudent>>(result);
                    foreach(var student in data)
                    {
                        Console.WriteLine($"Code: {student.code}\tName: {student.name}\tDate Of Birth: {student.date_of_birth.ToString().Split(" ")[0]}\tSex: {student.sex}\tPhone Number: {student.phone_number}\tUpdate At: {student.updated_at}");
                    }
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode} - {errorContent}");
                }
            }
        }

        public async Task GetDataAsync(string endpoint, int id)
        {}

        // public async Task PutData(string endpoint, object data)
        // {
        //     try
        //     {
        //         var request = new HttpRequestMessage(HttpMethod.Put, endpoint);
        //         var json = JsonSerializer.Serialize(data);
        //         Console.WriteLine(json);
        //         HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
        //         request.Content = content;
        //         var response = await _client.SendAsync(request);
        //         response.EnsureSuccessStatusCode();
        //         Console.WriteLine(await response.Content.ReadAsStringAsync());
        //     }
        //     catch(Exception ex)
        //     {
        //         Console.WriteLine(ex.Message);
        //     }
        // }

        // public async Task DeleteData(string endpoint)
        // {
        //     var response = await _client.DeleteAsync(endpoint);

        //     if (response.IsSuccessStatusCode)
        //     {
        //         string result = await response.Content.ReadAsStringAsync();
        //         Console.WriteLine("DELETE request successful. Response: " + result);
        //     }
        //     else
        //     {
        //         Console.WriteLine("DELETE request failed");
        //     }
        // }
    }
}