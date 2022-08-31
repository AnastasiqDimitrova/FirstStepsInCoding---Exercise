using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            //Calculations
            int volumeAqvarium = length * width * height;
            double volumeInLiters = volumeAqvarium * 0.001;
            double occupiedSpace = percent / 100.00;
            double litersNeeded = volumeInLiters * (1 - occupiedSpace);
            Console.WriteLine(litersNeeded);
        }
    }
}
