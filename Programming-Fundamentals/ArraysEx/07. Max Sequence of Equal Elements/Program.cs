using System;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            int bestCounter = 0;
            int bestIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string currentElement = arr[i];
                int counter = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentElement == arr[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > bestCounter )
                {
                    bestCounter = counter;
                    bestIndex = i;
                }
            }

            for (int i = 0; i < bestCounter; i++)
            {
                Console.Write(arr[bestIndex] + " ");
            }
        }
    }
}
