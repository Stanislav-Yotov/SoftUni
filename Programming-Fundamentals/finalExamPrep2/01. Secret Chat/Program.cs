using System;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var input = string.Empty;


            while ((input = Console.ReadLine()) != "Reveal")
            {
                var oper = input.Split(":|:");
                var action = oper[0];


                if (action == "InsertSpace")
                {
                    var index = int.Parse(oper[1]);
                    var wordLength = word.Length;

                    var line1 = word.Substring(0, index);
                    var line2 = word.Substring(index);

                    word = line1 + " " + line2;
                    
                    Console.WriteLine(word);
                }

                else if (action == "Reverse")
                {
                    var substr = oper[1];

                    if (word.Contains(substr))
                    {
                        var reversedSubstr = string.Empty;
                        var index = word.IndexOf(substr);

                        word = word.Remove(index, substr.Length);

                        for (int i = substr.Length - 1; i >= 0; i--)
                        {
                            reversedSubstr += substr[i];
                        }
                        word = word.Insert(index, reversedSubstr);
                        Console.WriteLine(word);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (action == "ChangeAll")
                {
                    var substr = oper[1];
                    var newSubstr = oper[2];

                    word = word.Replace(substr, newSubstr);
                    Console.WriteLine(word);
                }


            }
            Console.WriteLine($"You have a new text message: {word}");
        }
    }
}




