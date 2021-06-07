using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] firstArray = new string[n];
            string[] secondArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentArray = Console.ReadLine().Split().ToArray();

                string indexZero = currentArray[0];
                string indexOne = currentArray[1];

                if (i % 2 == 0)
                {
                    firstArray[i] = indexZero;
                    secondArray[i] = indexOne;
                }
                else if (i % 2 == 1)
                {
                    firstArray[i] = indexOne;
                    secondArray[i] = indexZero;
                }
            }

            Console.WriteLine(String.Join(" ", firstArray));
            Console.WriteLine(String.Join(" ", secondArray));
        }
    }
}
