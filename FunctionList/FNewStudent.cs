using Student_Enroll_Console.Model;
using Student_Enroll_Console.Controller;

namespace Student_Enroll_Console.FunctionList
{
    public class OptionsNewStudent
    {
        NewStudent newStudent = new NewStudent();
        NewStudentController studentController = new NewStudentController();
        public async Task SeletionNewStudent()
        {
            Console.WriteLine("1. Create New Student");
            Console.WriteLine("2. Get All New Students");
            Console.WriteLine("3. Get New Student");
            Console.WriteLine("4. Update New Student");
            Console.WriteLine("5. Delete New Student");
            Console.Write("Choose an option: ");
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
                    await studentController.SetNewStudentAsync(newStudent);
                    break;
                case 2:
                    await studentController.GetAllNewStudent();
                    break;
                case 3:
                    Console.Write("Input your student ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    await studentController.GetNewStudent(id);
                    break;
                default:
                    break;
            }
        }
    }
}