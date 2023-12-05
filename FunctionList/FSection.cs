using Student_Enroll_Console.Model;
using Student_Enroll_Console.Controller;

namespace Student_Enroll_Console.FunctionList
{
    public class OptionsSection
    {
        Section section = new Section();
        SectionController sectionController = new SectionController();
        public async Task SeletionSection()
        {
            Console.WriteLine("\n1. Create New Section");
            Console.WriteLine("2. Get All Section");
            Console.WriteLine("3. Get Section");
            Console.WriteLine("4. Update Section");
            Console.WriteLine("5. Delete Section");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            int purpose = Convert.ToInt32(Console.ReadLine());
            switch(purpose)
            {
                case 1:
                    Console.Write("\nInput Section Code: ");
                    section.code = Console.ReadLine();
                    Console.Write("Input Section Name: ");
                    section.name = Console.ReadLine();
                    Console.Write("Input Section Checkin Time: ");
                    section.checkin_time = TimeSpan.Parse(Console.ReadLine());
                    Console.Write("Input Section Checkout Time: ");
                    section.checkout_time = TimeSpan.Parse(Console.ReadLine());
                    await sectionController.SetSectionAsync(section);
                    break;
                case 2:
                    await sectionController.GetAllSectionAsync();
                    break;
                case 3:
                    Console.Write("\nInput Section ID: ");
                    int sectionId = Convert.ToInt32(Console.ReadLine());
                    await sectionController.GetSectionAsync(sectionId);
                    break;
                case 4:
                    Console.Write("\nInput Section ID: ");
                    section.id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Section Code: ");
                    section.code = Console.ReadLine();
                    Console.Write("Input Section Name: ");
                    section.name = Console.ReadLine();
                    Console.Write("Input Section Checkin Time: ");
                    section.checkin_time = TimeSpan.Parse(Console.ReadLine());
                    Console.Write("Input Section Checkout Time: ");
                    section.checkout_time = TimeSpan.Parse(Console.ReadLine());
                    await sectionController.UpdateSectionAsync(section);
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