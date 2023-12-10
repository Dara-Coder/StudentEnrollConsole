using System.Text.Json;
using Student_Enroll_Console.Model;

namespace Student_Enroll_Console.Controller
{
    public class NewStudentController
    {
        ApiCall api = new ApiCall();
        Uri baseUri = new Uri("https://localhost:7130/");
        public async Task SetNewStudentAsync(NewStudent newStudent){
            newStudent.created_at = DateTime.Now;
            newStudent.updated_at = DateTime.Now;
            await api.PostDataAsync(baseUri+"api/NewStudent",newStudent);
        }
        public async Task GetAllNewStudent(){
            var result = await api.GetAllDataAsync(baseUri+"api/NewStudent");
            List<NewStudent>? data = JsonSerializer.Deserialize<List<NewStudent>>(result);
            foreach(var student in data)
            {
                Console.WriteLine($"ID: {student.id}\tCode: {student.code}\tName: {student.name}\tDate Of Birth: {student.date_of_birth.ToString().Split(" ")[0]}\tSex: {student.sex}\tPhone Number: {student.phone_number}\tUpdate At: {student.updated_at}");
            }
        }
        public async Task GetNewStudent(int id){
            var result = await api.GetDataAsync(baseUri+"api/NewStudent",id);
            NewStudent? student = JsonSerializer.Deserialize<NewStudent>(result);
            Console.WriteLine($"ID: {student.id}\tCode: {student.code}\tName: {student.name}\tSex: {student.sex}\tDate Of Birth: {student.date_of_birth.ToString().Split(" ")[0]}\tPhone Number: {student.phone_number}\tUpdate At: {student.updated_at}");
        }
        public async Task UpdateNewStudent(NewStudent newStudent){
            await api.PutDataAsync(baseUri+"api/NewStudent",newStudent);
        }
        public async Task DeleteNewStudent(int id){
            await api.DeleteDataAsync(baseUri+"api/NewStudent",id);
        }
    }
}