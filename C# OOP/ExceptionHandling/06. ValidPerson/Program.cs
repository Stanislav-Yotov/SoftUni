using System;

namespace _06._ValidPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person pesho = new Person("petyr", "peshov", 80);

            }
            catch (ArgumentNullException e)
            { 
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Person gosho = new Person("", "goshov", 60);
            }
            catch (ArgumentNullException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Person dimo = new Person("dimo", "dimov", -1);
            }
            catch (ArgumentNullException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Person simo = new Person("simo", "simov", 121);
            }
            catch (ArgumentNullException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
