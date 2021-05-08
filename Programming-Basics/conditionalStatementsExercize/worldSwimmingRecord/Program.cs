using System;

namespace worldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            double distanceInSeconds = distance * seconds;
            double delay = Math.Floor(distance / 15) * 12.5;

            double finalTime = distanceInSeconds + delay;
            if (finalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
            }
            else
            {
                double neededTime = finalTime - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {neededTime:f2} seconds slower.");
            }
        }
    }
}
