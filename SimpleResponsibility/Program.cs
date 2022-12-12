namespace SimpleResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "UlviAdilov";
            string password = "ulvi123";
            CRUD crud = new CRUD();
            UserChecker userChecker = new UserChecker();
            User user = new User();
            if (userChecker.CheckPassword(password))
            {
                user.Password = password;
            }
            if (userChecker.CheckUsername(username))
            {
                user.Username = username;
            }

            crud.Create(user);

            foreach (User item in crud.GetAll())
            {
                Console.WriteLine(item.Username + " " + item.Password);
            }
            Console.WriteLine("==================================");
            crud.Remove(user);

            foreach (User item in crud.GetAll())
            {
                Console.WriteLine(item.Username + " " + item.Password);
            }
        }
    }
}