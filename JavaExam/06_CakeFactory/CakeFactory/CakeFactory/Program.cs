using System;

namespace CakeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Cake smallCake = new Cake();
            Cake bigCake = new Cake(15, 2);

            double volumeOfSmallCake = smallCake.CalculateVolume();
            double totalVolumeOfSmallCakes = smallCake.CalculateTotalVolume(volumeOfSmallCake, 100);
            smallCake.CalculateTotalCost(totalVolumeOfSmallCakes, 0.06);




        }
    }
}
