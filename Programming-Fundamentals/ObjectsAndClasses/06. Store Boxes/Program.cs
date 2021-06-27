using System;

namespace _06._Store_Boxes
{
    class Program
    {
        class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }
        class Box
        {
            public Box()
            {
                Item = new Item();
            }
            public string  SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public decimal PriceBox { get; set; }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
