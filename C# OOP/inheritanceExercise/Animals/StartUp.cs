using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string input;

            while ((input = Console.ReadLine()) != "Beast!")
            {
                string[] inputArgs = input.Split();
                string name = inputArgs[0];
                int age = int.Parse(inputArgs[1]);
                string gender = inputArgs[2];
                Animal currAnimal;

                if (age > 0)
                {
                    if (input == "Dog")
                    {
                        currAnimal = new Dog(name, age, gender);
                    }
                    else if (input == "Frog")
                    {
                        currAnimal = new Frog(name, age, gender);
                    }
                    else if (input == "Cat")
                    {
                        currAnimal = new Cat(name, age, gender);
                    }
                    else if (input == "Kitten")
                    {
                        currAnimal = new Kitten(name, age);
                    }
                    else if (input == "Tomcat")
                    {
                        currAnimal = new Tomcat(name, age);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input!");
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                animals.Add(currAnimal);

            }
                Console.WriteLine(string.Join(Environment.NewLine, animals));
        }
    }
}


