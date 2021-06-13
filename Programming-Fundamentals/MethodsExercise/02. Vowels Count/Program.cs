using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            //a, e, i, o, u and sometimes y

            string input = Console.ReadLine().ToLower();
            int result = VowelsCount(input);
            Console.WriteLine(result);

        }

        static int VowelsCount(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                
                if (currentChar == 'a')
                {
                    counter++;
                }
                else if (currentChar == 'e')
                {
                    counter++;
                }
                else if (currentChar == 'i')
                {
                    counter++;
                }
                else if (currentChar == 'o')
                {
                    counter++;
                }
                else if (currentChar == 'u')
                {
                    counter++;
                }
                else if (currentChar == 'y')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
 }

