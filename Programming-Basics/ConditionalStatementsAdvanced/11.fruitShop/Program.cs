using System;

namespace _11.fruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            switch (dayOfWeek)
            {
                case "Monday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.50;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "apple":
                            price = 1.20;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "orange":
                            price = 0.85;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "grapefruit":
                            price = 1.45;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "kiwi":
                            price = 2.70;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "pineapple":
                            price = 5.50;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "grapes":
                            price = 3.85;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;

                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "Tuesday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.50;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "apple":
                            price = 1.20;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "orange":
                            price = 0.85;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "grapefruit":
                            price = 1.45;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "kiwi":
                            price = 2.70;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "pineapple":
                            price = 5.50;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "grapes":
                            price = 3.85;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;

                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "Wednesday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.50;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "apple":
                            price = 1.20;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "orange":
                            price = 0.85;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "grapefruit":
                            price = 1.45;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "kiwi":
                            price = 2.70;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "pineapple":
                            price = 5.50;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "grapes":
                            price = 3.85;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;

                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Thursday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.50;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "apple":
                            price = 1.20;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "orange":
                            price = 0.85;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "grapefruit":
                            price = 1.45;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "kiwi":
                            price = 2.70;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "pineapple":
                            price = 5.50;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "grapes":
                            price = 3.85;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;

                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.50;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "apple":
                            price = 1.20;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "orange":
                            price = 0.85;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "grapefruit":
                            price = 1.45;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "kiwi":
                            price = 2.70;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "pineapple":
                            price = 5.50;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "grapes":
                            price = 3.85;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                            
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.70;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "apple":
                            price = 1.25;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "orange":
                            price = 0.90;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "grapefruit":
                            price = 1.60;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "kiwi":
                            price = 3;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "pineapple":
                            price = 5.60;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "grapes":
                            price = 4.20;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                            
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.70;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "apple":
                            price = 1.25;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "orange":
                            price = 0.90;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "grapefruit":
                            price = 1.60;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "kiwi":
                            price = 3;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "pineapple":
                            price = 5.60;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                        case "grapes":
                            price = 4.20;
                            Console.WriteLine($"{quantity * price:f2}");
                            break;
                            
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                    

                default:
                    Console.WriteLine("error");
                    break;
            }



        }
    }
}