using Student_Enroll_Console.FunctionList;

namespace Student_Enroll_Console
{
    public class OptionsMenu
    {
        public async Task OptionsMenuList()
        {
            Console.WriteLine("Choose your choice to enroll student:");
            Console.WriteLine("1. NewStudent");
            Console.WriteLine("2. Enroll Student");
            Console.WriteLine("3. Section");
            Console.WriteLine("4. Subject");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an options: ");
            int purpose = Convert.ToInt32(Console.ReadLine());
            switch(purpose)
            {
                case 1 :
                    await new OptionsNewStudent().SeletionNewStudent();
                    break;
                case 2:
                    await new OptionsEnrollStudent().SeletionEnrollStudent();
                    break;
                case 3:
                    await new OptionsSection().SeletionSection();
                    break;
                case 4:
                    await new OptionsSubject().SeletionSubject();
                    break;
                case 5:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}