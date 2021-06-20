using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deckOne = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToList();

            List<int> deckTwo = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToList();

            while (deckOne.Count != 0 && deckTwo.Count != 0)
            {
                int firstPlayerCard = deckOne[0];
                int secondPlayerCard = deckTwo[0];

                if (firstPlayerCard > secondPlayerCard)
                {
                    deckOne.Add(firstPlayerCard);
                    deckOne.Add(secondPlayerCard);

                    deckOne.RemoveAt(0);
                    deckTwo.RemoveAt(0);
                }
                else if (firstPlayerCard < secondPlayerCard)
                {
                    deckTwo.Add(secondPlayerCard);
                    deckTwo.Add(firstPlayerCard);

                    deckOne.RemoveAt(0);
                    deckTwo.RemoveAt(0);
                }
                else
                {
                    deckOne.RemoveAt(0);
                    deckTwo.RemoveAt(0);
                }
            }

            if (deckOne.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {deckTwo.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {deckOne.Sum()}");
            }
        }
    }
}
