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
            int purpose;
            do
            {
                Console.WriteLine("\n1. Create New Student");
                Console.WriteLine("2. Get All New Students");
                Console.WriteLine("3. Get New Student");
                Console.WriteLine("4. Update New Student");
                Console.WriteLine("5. Delete New Student");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                purpose = Convert.ToInt32(Console.ReadLine());
                switch(purpose)
                {
                    case 1:
                        Console.Write("\nInput Student Code: ");
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
                        Console.WriteLine();
                        await studentController.GetAllNewStudent();
                        break;
                    case 3:
                        Console.Write("\nInput your student ID: ");
                        int idGet = Convert.ToInt32(Console.ReadLine());
                        await studentController.GetNewStudent(idGet);
                        break;
                    case 4:
                        Console.Write("\nInput Student ID: ");
                        newStudent.id = Convert.ToInt32(Console.ReadLine());
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
                        await studentController.UpdateNewStudent(newStudent);
                        break;
                    case 5:
                        Console.Write("\nInput Student ID: ");
                        int idDelete = Convert.ToInt32(Console.ReadLine());
                        await studentController.DeleteNewStudent(idDelete);
                        break;
                    case 6:
                        Console.Clear();
                        await new OptionsMenu().OptionsMenuList();
                        break;
                    default:
                        break;
                }
            }while(purpose != 6);
        }
    }
}