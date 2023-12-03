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
            await api.PostData(baseUri+"api/NewStudent",newStudent);
        }
        public async Task GetAllNewStudent(){
            await api.GetAllDataAsync(baseUri+"api/NewStudent");
        }
        public async Task GetNewStudent(int id){
            await api.GetDataAsync(baseUri+"api/NewStudent",id);
        }
        public async Task UpdateNewStudent(NewStudent newStudent){
            await api.PutDataAsync(baseUri+"api/NewStudent",newStudent);
        }
        public async Task DeleteNewStudent(int id){
            await api.DeleteDataAsync(baseUri+"api/NewStudent",id);
        }
    }
}