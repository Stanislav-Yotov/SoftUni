using System;
using System.Linq;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            foreach (var phoneNumber in phoneNumbers)
            {
                if (phoneNumber.Any(c => char.IsLetter(c)))
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }

                ICallable currentPhone = null;
                if (phoneNumber.Length == 7)
                {
                    currentPhone = new StationaryPhone();
                }
                else if (phoneNumber.Length == 10)
                {
                    currentPhone = new Smartphone();
                }
                currentPhone.Call(phoneNumber);
            }

            foreach (var url in urls)
            {
                if (url.Any(c => char.IsDigit(c)))
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }
                Smartphone smartPhone = new Smartphone();
                smartPhone.Browse(url);
            }

           
        }
    }
}
