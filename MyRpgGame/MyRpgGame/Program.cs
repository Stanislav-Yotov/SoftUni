using System;

namespace MyRpgGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Здравей пътешественико, моля избери своето бойно име!");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Привет {playerName}!");
            int playerHp = 100;
            int playerXp = 0;
            int playerLvl = 1;
            int playerAtt = 10;
            int playerCoins = 0;
            bool isAlive = true;
            int roomCount = 1;
            int bonusPlayerCoins = 0;

            while (isAlive)
            {
                Console.WriteLine($"===Стая: {roomCount}===");
                roomCount++;
                int roomType = new Random().Next(1, 6);
                switch (roomType)
                {
                    case 1:
                    case 2:
                    case 3:


                        Console.WriteLine("Срещна чудовище!");
                        int monsterAtt = new Random().Next(5, 50);
                        int monsterHp = new Random().Next(2, 40);
                        bool isWon = false;

                        while (!isWon && isAlive)
                        {
                            Console.WriteLine("Какво ще направиш?");
                            Console.WriteLine("1. ще се бия!");
                            Console.WriteLine("2. ще се опитам да избягам.");
                            int choice = int.Parse(Console.ReadLine());
                            if (choice == 1)
                            {
                                while (isAlive && !isWon)
                                {
                                    monsterHp -= playerAtt;
                                    if (monsterHp <= 0)
                                    {
                                        Console.WriteLine("Ти победи!");
                                        playerXp += 1;
                                        if (playerXp >= 100)
                                        {
                                            playerLvl++;
                                            playerAtt += 10;
                                            playerXp -= 100;
                                        }
                                        playerCoins = new Random().Next(15, 100);
                                        isWon = true;
                                        break;
                                    }

                                    playerHp -= monsterAtt;
                                    if (playerHp <= 0)
                                    {
                                        isAlive = false;
                                        break;
                                    }
                                }
                                Console.WriteLine($"За битката получаваш {playerCoins} жълтици!");
                                Console.WriteLine($"Оставащо здраве: {playerHp} ");
                                Console.WriteLine($"Оставащо здраве на чудовището: {monsterHp} ");
                            }
                            else if (choice == 2)
                            {
                                Console.WriteLine("Ти избяга. :) ");
                                break;
                            }
                            else if (choice != 1 && choice != 2)
                            {
                                Console.WriteLine("Изгуби шанса си за тази стая :)");
                                break;
                            }

                        }
                        break;

                    case 4:
                        Console.WriteLine("Намери прашна кутия.");
                        while (true)
                        {
                            Console.WriteLine("Искаш ли да я отвориш?");
                            Console.WriteLine("1.=== Да.===");
                            Console.WriteLine("2.=== Не. ===");
                            int choice = int.Parse(Console.ReadLine());
                            if (choice == 1)
                            {
                                bonusPlayerCoins = new Random().Next(15, 100);
                                Console.WriteLine($"Получаваш {bonusPlayerCoins} жълтици");
                                
                                break;
                            }
                            else if (choice == 2)
                            {
                                Console.WriteLine("Повече смелост следващия път ;)");
                                break;
                            }
                            else if (choice != 1 && choice != 2)
                            {
                                Console.WriteLine("Изгуби шанса си за тази стая :)");
                                break;
                            }
                        }
                        break;



                    case 5:
                        Console.WriteLine("Намери колба със странна смес.");
                        while (true)
                        {
                            Console.WriteLine("Ще се осмелиш ли да я изпиеш?");
                            Console.WriteLine("1. Да, съдбата обича смелите.");
                            Console.WriteLine("2. Не, предпочитам да не рискувам.");
                            int choice = int.Parse(Console.ReadLine());
                            if (choice == 1)
                            {
                               int bonusPlayerHp = new Random().Next(10, 30);
                                Console.WriteLine($"Получаваш {bonusPlayerHp} точки здраве!");
                                Console.WriteLine($"Оставащо здраве: {playerHp + bonusPlayerHp} ");
                                break;
                            }

                            else if (choice == 2)
                            {
                               int penaltyPlayerHp = new Random().Next(5, 20);
                                Console.WriteLine($"Загуби {penaltyPlayerHp} точки здраве...");
                                Console.WriteLine($"Оставащо здраве: {playerHp - penaltyPlayerHp} ");
                                break;
                            }
                            else if (choice != 1 && choice != 2)
                            {

                                Console.WriteLine("Изгуби шанса си за тази стая :)");
                                break;
                            }
                        }
                        break;


                }
            }

            Console.WriteLine("Играта приключи за теб!");
            Console.WriteLine($"Жълтици: {playerCoins + bonusPlayerCoins} ");













        }
    }
}
