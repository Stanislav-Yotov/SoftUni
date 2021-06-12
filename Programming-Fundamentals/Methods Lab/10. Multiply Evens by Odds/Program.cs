using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int[] array = new int[n.Length];
            int startindex = 0;
            if (n[0] == '-')
            {
                startindex = 1;
                for (int i = startindex; i < n.Length; i++)
                {
                    array[i] = int.Parse(n[i].ToString());
                }
            }
            else
            {
                for (int i = 0; i < n.Length; i++)
                {
                    array[i] = int.Parse(n[i].ToString());

                }
            }


            double result = Multiply(array);
            Console.WriteLine(result);
        }

        static int Multiply(int[] array)
        {
            int result = GetSumOfEvenDigits(array) * GetSumOfOddDigits(array);
            return result;
        }

        static int GetSumOfOddDigits(int[] array)
        {
            int sumOdd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sumOdd += array[i];
                }
            }
            return sumOdd;
        }
        static int GetSumOfEvenDigits(int[] array)
        {
            int sumEven = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumEven += array[i];
                }
            }
            return sumEven;
        }
    }
}
