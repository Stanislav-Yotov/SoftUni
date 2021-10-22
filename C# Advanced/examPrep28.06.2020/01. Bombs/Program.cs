using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEfects = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> bombCasings = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int daturaBombs = 0, cherryBombs = 0, smokeDecoyBombs = 0;
            bool isReady = false;

            while (bombEfects.Count > 0 && bombCasings.Count > 0)
            {
                int bombEfect = bombEfects.Peek();
                int bombCasing = bombCasings.Peek();
                if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                {
                    isReady = true;
                    break;
                }

                if (bombEfect + bombCasing == 40)
                {
                    daturaBombs++;
                    bombCasings.Pop();
                    bombEfects.Dequeue();
                }
                else if (bombEfect + bombCasing == 60)
                {
                    cherryBombs++;
                    bombCasings.Pop();
                    bombEfects.Dequeue();
                }
                else if (bombEfect + bombCasing == 120)
                {
                    smokeDecoyBombs++;
                    bombCasings.Pop();
                    bombEfects.Dequeue();
                }
                else
                {
                    bombCasing -= 5;
                    bombCasings.Pop();
                    bombCasings.Push(bombCasing);
                }
            }

            if (isReady)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (bombEfects.Any())
            {
                Console.Write("Bomb Effects:" + " ");
                Console.WriteLine(string.Join(", ", bombEfects));
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            if (bombCasings.Any())
            {
                Console.Write("Bomb Casings:" + " ");
                Console.WriteLine(string.Join(", ", bombCasings));
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {daturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");



        }
    }
}
