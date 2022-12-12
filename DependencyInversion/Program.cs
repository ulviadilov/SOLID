namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Email email= new Email();
            email.Send();
            Sms sms = new Sms();
            sms.Send();
            Console.WriteLine("===========================================");
            List<IMessageSender>  senderList = new List<IMessageSender>();
            senderList.Add(sms);
            senderList.Add(email);

            MessageSender messageSender = new MessageSender(senderList);
            messageSender.Send();
        }
    }
}