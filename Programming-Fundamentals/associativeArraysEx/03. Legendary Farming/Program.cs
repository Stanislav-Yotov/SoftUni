using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();


            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;

            bool isCreated = false;

            while (!isCreated)
            {
                string[] input = Console.ReadLine().ToLower().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;
                            isCreated = true;

                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, quantity);
                        }
                        else
                        {
                            junkMaterials[material] += quantity;
                        }
                    }

                    if (isCreated)
                    {


                        if (material == "shards")
                        {

                            Console.WriteLine("Shadowmourne obtained!");
                        }
                        else if (material == "fragments")
                        {

                            Console.WriteLine("Valanyr obtained!");

                        }
                        else if (material == "motes")
                        {

                            Console.WriteLine("Dragonwrath obtained!");

                        }




                        keyMaterials = keyMaterials
                                                .OrderByDescending(v => v.Value)
                                                .ThenBy(k => k.Key)
                                                .ToDictionary(k => k.Key, v => v.Value);

                        foreach (var keyMaterial in keyMaterials)
                        {
                            Console.WriteLine(string.Join(Environment.NewLine,
                                                $"{keyMaterial.Key}: {keyMaterial.Value}"));
                        }

                        foreach (var junkMaterial in junkMaterials)
                        {
                            Console.WriteLine(string.Join(Environment.NewLine,
                                                $"{junkMaterial.Key}: {junkMaterial.Value}"));
                        }
                        break;
                    }
                }
            }
        }
    }
}
