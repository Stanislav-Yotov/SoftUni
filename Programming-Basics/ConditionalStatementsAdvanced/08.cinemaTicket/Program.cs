using System;

namespace _08.cinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            //Monday Tuesday Wednesday Thursday    Friday Saturday  Sunday
            // 12      12       14      14            12    16        16
            string dayOfWeek = Console.ReadLine();
            int price = 0;
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    price = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    price = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    price = 16;
                    break;
            }
            Console.WriteLine(price);


        }
    }
}
