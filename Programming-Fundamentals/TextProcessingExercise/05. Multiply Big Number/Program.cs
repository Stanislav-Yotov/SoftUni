using System;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string longNum = Console.ReadLine().TrimStart('0');
            int num = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int temp = 0;

            if (num == 0 || longNum == " ")
            {
                Console.WriteLine(0);
                return;
            }

            foreach (char c in longNum.Reverse())
            {
                int digit = int.Parse(c.ToString());
                int result = digit * num + temp;

                int lastDigit = result % 10;
                temp = result / 10;

                sb.Insert(0, lastDigit);
            }

            if (temp > 0)
            {

                sb.Insert(0, temp);
            }


            Console.WriteLine(sb.ToString());

        }
    }
}
