using System;

namespace _02.spaceShip
{
    class Program
    {
        static void Main(string[] args)
        {
            double shipWidth = double.Parse(Console.ReadLine());
            double shipLength = double.Parse(Console.ReadLine());
            double shipHeight = double.Parse(Console.ReadLine());
            double averageAstrounautHeight = double.Parse(Console.ReadLine());

            double astronautRoom = 2 * 2 * (averageAstrounautHeight + 0.40);
            double shipVolume = shipWidth * shipLength * shipHeight;
            double astronautCount = Math.Floor(shipVolume / astronautRoom);
            if (astronautCount >= 3 && astronautCount <= 10)
            {
                Console.WriteLine($"The spacecraft holds {astronautCount} astronauts.");

            }
            else if (astronautCount < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (astronautCount > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }

        }
    }
}
