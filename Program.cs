using Student_Enroll_Console.Controller;

namespace Student_Enroll_Console
{
    public class Program
    {
        public void OptionsChoice()
        {
            Console.WriteLine("Choose your choice to enroll student: ");
            Console.WriteLine("1/ NewStudent\n2/ Enroll Student\n3/ Section\n4/ Subject");
            int purpose = Convert.ToInt32(Console.ReadLine());
            switch(purpose)
            {
                case 1 :
                    new ExecuteNewStudent().InputNewStudent();
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            new Program().OptionsChoice();
        }
    }
}