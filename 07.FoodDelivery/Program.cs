using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countChicken = int.Parse(Console.ReadLine());
            int countFish = int.Parse(Console.ReadLine());
            int countVegan = int.Parse(Console.ReadLine());

            double priceChicken = countChicken * 10.35;
            double priceFish = countFish * 12.40;
            double priceVegan = countVegan * 8.15;
            double priceMenus = priceChicken + priceFish + priceVegan;
            double desertPrice = 0.2 * priceMenus;

            double totalPrice = priceMenus + desertPrice + 2.50;

            Console.WriteLine(totalPrice);
        }
    }
}
