namespace Liskov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer();  
            developer.GetFullname();
            developer.GetExperience();
            developer.GetAge(); 

            Student student = new Student();
            student.GetFullname();
            student.GetAge();
        }
    }
}