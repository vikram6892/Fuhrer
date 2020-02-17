using System;
using System.Collections.Generic;
using System.Text;

namespace CakeFactory
{
    class Cake{

        float radius;
        float height;
        static double pi = 3.1416;

        // Prepare Small cake by default
        public Cake(){
            radius = 10; 
            height = 2;
        }

        // Prepare cake of any size based on user input
        public Cake(float _radius, float _height){
            radius = _radius;
            height = _height;
        }

        public double CalculateVolume(){
            double volume = Cake.pi * radius * radius * height;
            return volume;
        }

        public double CalculateTotalVolume(double _volume, int numberOfPieces){
            double totalVolume = _volume * numberOfPieces;
            return totalVolume;
        }

        public void CalculateTotalCost(double _totalVolume, double costPerPiece)
        {
            double totalCost = _totalVolume * costPerPiece;
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("                        SMALL CAKE COST                          ");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Total cost of manufacturing small cakes : " + totalCost + " Euros");
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
