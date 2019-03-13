namespace _04._Telephony
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Smartphone phone = new Smartphone();

            phone.PhoneNumbers = Console.ReadLine()
                .Split()
                .ToList();

            phone.WebSites = Console.ReadLine()
                .Split()
                .ToList();

            Console.WriteLine(phone);
        }
    }
}
