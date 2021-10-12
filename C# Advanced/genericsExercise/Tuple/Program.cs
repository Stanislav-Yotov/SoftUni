using System;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string name = $"{firstInput[0]} {firstInput[1]}";
            string adress = firstInput[2];
            Tuple<string, string> firstTuple = new Tuple<string, string>(name, adress);
            Console.WriteLine(firstTuple);
            string[] secondInput = Console.ReadLine().Split();
            string secondName = secondInput[0];
            int liters = int.Parse(secondInput[1]);
            Tuple<string, int> secondTuple = new Tuple<string, int>(secondName, liters);
            Console.WriteLine(secondTuple);
            string[] thirdInput = Console.ReadLine().Split();
            int integer = int.Parse(thirdInput[0]);
            double doubleNum = double.Parse(thirdInput[1]);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(integer, doubleNum);
            Console.WriteLine(thirdTuple);
        }
    }
}
