using System;
using System.Linq;

namespace _03._countUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().Where(c => char.IsUpper(c[0])).ToArray();
            foreach (var word in text)
            {
                Console.WriteLine(word);
            }

        }
    }
}
