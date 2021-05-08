using System;

namespace _03.vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingCounter = 0;
            while (neededMoney > ownedMoney && spendingCounter < 5)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;
                if (action == "save")
                {
                    ownedMoney += money;
                    spendingCounter = 0;
                }
                else if (action == "spend")
                {
                    ownedMoney -= money;
                    if (ownedMoney <= 0)
                    {
                        ownedMoney = 0;
                    }
                    spendingCounter++;
                    
                }
            }
            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (ownedMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
               

        }
    }
}
