using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceForNylon = 1.5;
            double priceForPaint = 14.5;
            double priceForRazreditel = 5;
            double priceForBags = 0.4;
            //Input
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            //Calculations
            double sumForNylon = (nylon + 2) * priceForNylon;
            double sumForPaint = (paint + paint * 0.1) * priceForPaint;
            double sumForRazreditel = razreditel * priceForRazreditel;
            double sumForMaterials = sumForNylon + sumForPaint + sumForRazreditel + priceForBags;
            double priceForMaistor = sumForMaterials * 0.3 * hours;
            double finalPrice = sumForMaterials + priceForMaistor;
            Console.WriteLine(finalPrice);
        }
    }
}
