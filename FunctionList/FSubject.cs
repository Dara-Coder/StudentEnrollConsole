using Student_Enroll_Console.Model;
using Student_Enroll_Console.Controller;

namespace Student_Enroll_Console.FunctionList
{
    public class OptionsSubject
    {
        SubjectController subjectController = new SubjectController();
        Subject subject = new Subject();
        public async Task SeletionSubject()
        {
            int purpose;
            do
            {
                Console.WriteLine("\n1. Create New Subject");
                Console.WriteLine("2. Get All Subject");
                Console.WriteLine("3. Get Subject");
                Console.WriteLine("4. Update Subject");
                Console.WriteLine("5. Delete Subject");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an options: ");
                purpose = Convert.ToInt32(Console.ReadLine());
                switch(purpose)
                {
                    case 1:
                        Console.Write("\nInput Subject Code: ");
                        subject.code = Console.ReadLine();
                        Console.Write("Input Subject Name: ");
                        subject.name = Console.ReadLine();
                        Console.Write("Input Subject Fee: ");
                        subject.fee = (float)Convert.ToDecimal(Console.ReadLine());
                        await subjectController.SetSubjectAsync(subject);
                        break;
                    case 2:
                        await subjectController.GetAllSubjectAsync();
                        break;
                    case 3:
                        Console.Write("\nInput Subject ID: ");
                        int subjectId = Convert.ToInt32(Console.ReadLine());
                        await subjectController.GetSubjectAsync(subjectId);
                        break;
                    case 4:
                        Console.Write("\nInput Subject ID: ");
                        subject.id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Input Subject Code: ");
                        subject.code = Console.ReadLine();
                        Console.Write("Input Subject Name: ");
                        subject.name = Console.ReadLine();
                        Console.Write("Input Subject Fee: ");
                        subject.fee = (float)Convert.ToDecimal(Console.ReadLine());
                        await subjectController.UpdateSubjectAsync(subject);
                        break;
                    case 5:
                        Console.Write("\nInput Subject ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        await subjectController.DeleteSubjectAsync(id);
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