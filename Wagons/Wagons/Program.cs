using System;
using Wagons.Sourse;

namespace Wagons
{
    class Program
    {
        static void Main(string[] args)
        {            
            var train = TrainManagement.CreateTrain();
            Console.WriteLine($"Amount of wagons which was calculated:" +
                $" {WagonsAlgorithm.CalculateAmountOfWagons(train)}"); 
        }
    }
}
