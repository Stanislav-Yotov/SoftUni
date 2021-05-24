using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int firstNum = inputNum;
            int sum = 0;

            while (inputNum > 0)
            {
                int currentNum = inputNum % 10;

                int factoriel = 1;

                for (int i = 1; i <= currentNum; ++i)
                {
                    factoriel *= i;
                }

                sum += factoriel;
                inputNum /= 10;
            }

            if (firstNum == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
