using Student_Enroll_Console.Controller;
using Student_Enroll_Console.Model;

namespace Student_Enroll_Console.FunctionList
{
    public class OptionsEnrollStudent
    {
        EnrollStudent enrollStudent = new EnrollStudent();
        EnrollStudentController enrollStudentController = new EnrollStudentController();
        public async Task SeletionEnrollStudent()
        {
            Console.WriteLine("\n1. Create Enroll Student");
            Console.WriteLine("2. Get All Enroll Student");
            Console.WriteLine("3. Get Enroll Student");
            Console.WriteLine("4. Update Enroll Student");
            Console.WriteLine("5. Delete Enroll Student");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            int purpose = Convert.ToInt32(Console.ReadLine());
            switch(purpose)
            {
                case 1:
                    Console.Write("\nInput Student ID: ");
                    enrollStudent.newStudentId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Subject ID: ");
                    enrollStudent.subjectId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Section ID: ");
                    enrollStudent.sectionId = Convert.ToInt32(Console.ReadLine());
                    await enrollStudentController.SetEnrollStudent(enrollStudent);
                    break;
                case 2:
                    Console.WriteLine();
                    await enrollStudentController.GetAllEnrollStudent();
                    break;
                case 3:
                    Console.Write("\nInput Enroll ID: ");
                    int enrollId = Convert.ToInt32(Console.ReadLine());
                    await enrollStudentController.GetEnrollStudent(enrollId);
                    break;
                case 4:
                    Console.Write("\nInput Enroll ID: ");
                    enrollStudent.id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Student ID: ");
                    enrollStudent.newStudentId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Subject ID: ");
                    enrollStudent.subjectId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Section ID: ");
                    enrollStudent.sectionId = Convert.ToInt32(Console.ReadLine());
                    await enrollStudentController.UpdateEnrollStudent(enrollStudent);
                    break;
                case 6:
                    Console.Clear();
                    await new OptionsMenu().OptionsMenuList();
                    break;
                default:
                    break;
            }
        }
    }
}