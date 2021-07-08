using System;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            int[] wagon = Console.ReadLine()
                                      .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .ToArray();

            int peopleOnCurrentWagon = 0;
            int peopleOnTheLift = 0;
            bool noMorePeople = false;
            for (int i = 0; i < wagon.Length; i++)
            {
                while (wagon[i] < 4)
                {
                    wagon[i]++;
                    peopleOnCurrentWagon++;
                    if (peopleOnTheLift + peopleOnCurrentWagon == waitingPeople)
                    {
                        noMorePeople = true;
                        break;
                    }
                }
                peopleOnTheLift += peopleOnCurrentWagon;
                if (noMorePeople)
                {
                    break;
                }
                peopleOnCurrentWagon = 0;
            }

            if (waitingPeople > peopleOnTheLift)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople - peopleOnTheLift} people in a queue!");
                Console.WriteLine(string.Join(" ", wagon));
            }
            else if (waitingPeople < wagon.Length * 4 && wagon.Any(w => w < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagon));
            }
            else if (wagon.All(w => w == 4) && noMorePeople == true)
            {
                Console.WriteLine(string.Join(" ", wagon));
            }
        }
    }
}
