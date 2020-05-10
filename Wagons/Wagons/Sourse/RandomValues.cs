using System;

namespace Wagons.Sourse
{   
    static class RandomValues
    {
        static Random Random = new Random();
        public static bool ReturnStanForLight() => Convert.ToBoolean(Random.Next(0, 2));
        public static int ReturnRandomAmountOfVagons() => Random.Next(3, 10);          
        public static int ReturnNumberOfStartWagon(int amountOfVagons) => Random.Next(1, amountOfVagons - 1);
    }
}
