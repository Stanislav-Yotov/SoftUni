using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+$";
            Regex barcoderegex = new Regex(pattern);

            int count = int.Parse(Console.ReadLine());

            while (count-- > 0)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string productGroup = string.Empty;

                    for (int i = 0; i < match.Value.Length; i++)
                    {
                        if (char.IsDigit(match.Value[i]))
                        {
                            productGroup += match.Value[i];
                        }
                    }

                    if (productGroup != string.Empty)
                    {
                        Console.WriteLine($"Product group: {productGroup}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
            


        }
    }
}
