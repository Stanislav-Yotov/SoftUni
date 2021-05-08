using System;

namespace _04.walking
{
    class Program
    {
        static void Main(string[] args)
        {
           const int goal = 10000;
            int stepSum = 0;
            int stepsDifference = 0;
            

            while (stepSum < goal)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int stepsLeft = int.Parse(Console.ReadLine());
                    stepSum += stepsLeft;
                    break;
                }
                int steps = int.Parse(input);
                stepSum += steps;
                
                
            }
            if (stepSum >= goal)
            {
                stepsDifference = stepSum - goal;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsDifference} steps over the goal!");
            }
            else
            {
                stepsDifference = 10000 - stepSum;
                Console.WriteLine($"{stepsDifference} more steps to reach goal.");
            }
        }
    }
}
