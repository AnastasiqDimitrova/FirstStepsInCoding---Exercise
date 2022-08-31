using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double yearPaiment = double.Parse(Console.ReadLine());
            //Calculation
            double priceForShoes = yearPaiment * 0.6;
            double priceForClothes = priceForShoes - (priceForShoes * 0.2);
            double priceForBall = priceForClothes / 4;
            double priceForAccesories = priceForBall / 5;
            double finalPrice = yearPaiment + priceForClothes + priceForShoes + priceForBall + priceForAccesories;
            //Output
            Console.WriteLine(finalPrice);

        }
    }
}
