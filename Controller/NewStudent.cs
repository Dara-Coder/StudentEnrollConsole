using Student_Enroll_Console.Model;

namespace Student_Enroll_Console.Controller
{
    public class NewStudentController
    {
        Uri baseUri = new Uri("https://localhost:7130/");
        ApiCall api = new ApiCall();
        public void SetNewStudent(NewStudent newStudent){
            newStudent.created_at = DateTime.Now;
            newStudent.updated_at = DateTime.Now;
            _ = api.PostData(baseUri + "api/NewStudent", newStudent);
        }
        public void GetAllNewStudent(){}
        public void GetNewStudent(int id){}
        public void UpdateNewStudent(NewStudent newStudent){}
        public void DeleteNewStudent(int id){}
    }

    public class ExecuteNewStudent
    {
        NewStudent newStudent = new NewStudent();
        NewStudentController studentController = new NewStudentController();
        public void InputNewStudent()
        {
            Console.WriteLine("1/ Create New Student\n2/ GetAll New Student\n3/ Get New Student\n4/ Update New Student\n5/ Delete New Student\n");
            int purpose = Convert.ToInt32(Console.ReadLine());
            switch(purpose)
            {
                case 1:
                    Console.Write("Input Student Code: ");
                    newStudent.code = Console.ReadLine();
                    Console.Write("Input Student Name: ");
                    newStudent.name = Console.ReadLine();
                    Console.Write("Input Student Sex: ");
                    newStudent.sex = Console.ReadLine();
                    Console.Write("Input Student Date Of Birth: ");
                    newStudent.date_of_birth = DateTime.Parse(Console.ReadLine());
                    Console.Write("Input Student Phone Number: ");
                    newStudent.phone_number = Console.ReadLine();
                    studentController.SetNewStudent(newStudent);
                    break;
                default:
                    break;
            }
        }
    }
}