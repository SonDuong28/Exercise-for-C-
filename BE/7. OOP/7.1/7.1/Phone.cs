using System;
using System.Collections.Generic;
using System.Text;

namespace _7._1
{
    public class Phone
    {
        public string Brand;
        public string Model;
        public int Price;

        public Phone(string brand, string model, int price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }
        public void PrintSpecs()
        {
            Console.Write($"Brand:{Brand}, \n Model: {Model}, \n Price: {Price} \n");
        }
    }
}
