using System;

namespace _02.examPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badMark = int.Parse(Console.ReadLine());


            string problem = Console.ReadLine();
            
            double averageScore = 0;
            int numberOfProblems = 1;
            bool isPassed = true;
            int badMarkCounter = 0;
            string lastProblem = "";

            while (problem != "Enough")
            {
               int mark = int.Parse(Console.ReadLine());
                averageScore += mark;
                numberOfProblems++;

                if (mark <= 4)
                {
                    badMarkCounter++;
                    if (badMarkCounter == badMark)
                    {
                        isPassed = false;
                        break;
                    }
                }
                lastProblem = problem;
                problem = Console.ReadLine();
            }
            if (isPassed)
            {
                Console.WriteLine($"Average score: {averageScore / (numberOfProblems - 1):f2}");
                Console.WriteLine($"Number of problems: {--numberOfProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {badMarkCounter} poor grades.");
            }

        }
    }
}
