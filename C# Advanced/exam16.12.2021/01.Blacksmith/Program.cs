using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacksmith
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> steel = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> carbon = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int gladius = 0, shamshir = 0, katana = 0, sabre = 0, broadSword = 0;
            int swordsCount = 0;

            while (steel.Count > 0 && carbon.Count > 0)
            {
                int steelPiece = steel.Peek();
                int carbonPiece = carbon.Peek();
                int sword = steelPiece + carbonPiece;

                switch (sword)
                {
                    case 70:
                        gladius++;
                        steel.Dequeue();
                        carbon.Pop();
                        break;
                    case 80:
                        shamshir++;
                        steel.Dequeue();
                        carbon.Pop();
                        break;
                    case 90:
                        katana++;
                        steel.Dequeue();
                        carbon.Pop();
                        break;
                    case 110:
                        sabre++;
                        steel.Dequeue();
                        carbon.Pop();
                        break;
                    case 150:
                        broadSword++;
                        steel.Dequeue();
                        carbon.Pop();
                        break;
                    default:
                        steel.Dequeue();
                        carbon.Pop();
                        carbonPiece += 5;
                        carbon.Push(carbonPiece);
                        break;
                }
            }
            swordsCount = gladius + shamshir + katana + sabre + broadSword;
            if (swordsCount > 0)
            {
                Console.WriteLine($"You have forged {swordsCount} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }
            if (!steel.Any())
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steel)}");
            }
            if (!carbon.Any())
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbon)}");
            }
            if (broadSword > 0)
            {
                Console.WriteLine($"Broadsword: {broadSword}");
            }
            if (gladius > 0)
            {
                Console.WriteLine($"Gladius: {gladius}");
            }
            if (katana > 0)
            {
                Console.WriteLine($"Katana: {katana}");
            }
            if (sabre > 0)
            {
                Console.WriteLine($"Sabre: {sabre}");
            }
            if (shamshir > 0)
            {
                Console.WriteLine($"Shamshir: {shamshir}");
            }
        }
    }
}
