using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder nums = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder other = new StringBuilder();


            for (int i = 0; i < text.Length; i++)
            {
                char charText = text[i];

                if (char.IsDigit(charText))
                {
                    nums.Append(charText);
                }
                else if (char.IsLetter(charText))
                {
                    letters.Append(charText);
                }
                else
                {
                    other.Append(charText);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, nums, letters, other));

        }
    }
}
