using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTopNumber(number);
        }

        private static void PrintTopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                string currentNum = i.ToString();
                bool isOdd = false;
                int sumOfDigits = 0;

                foreach (var curr in currentNum)
                {
                    int parseNum = (int)curr;

                    if (parseNum % 2 == 1)
                    {
                        isOdd = true;
                    }

                    sumOfDigits += parseNum;
                }

                if (sumOfDigits % 8 == 0 && isOdd)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
