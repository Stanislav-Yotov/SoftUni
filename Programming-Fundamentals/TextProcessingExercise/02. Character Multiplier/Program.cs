using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string firstWord = input[0];
            string secondWord = input[1];

            string longerWord = firstWord;
            string shorterWord = secondWord;

            if (firstWord.Length < secondWord.Length)
            {
                longerWord = secondWord;
                shorterWord = firstWord;
            }

            int totalSum = MultiplyChars(longerWord, shorterWord);

            Console.WriteLine(totalSum);
        }

        static public int MultiplyChars(string longerWord, string shorterWord)
        {
            int sum = 0;

            for (int i = 0; i < shorterWord.Length; i++)
            {
                int multiply = longerWord[i] * shorterWord[i];
                sum += multiply;
            }

            for (int i = shorterWord.Length; i < longerWord.Length; i++)
            {
                sum += longerWord[i];
            }
            return sum;
        }
    }
}
