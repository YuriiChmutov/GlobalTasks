using System;
using System.Collections.Generic;
using Wagons.Model;

namespace Wagons.Sourse
{
    public static class TrainManagement
    {
        public static bool SwapLightState(bool stan) => !stan;
        public static List<Wagon> CreateTrain ()
        {
            var train = new List<Wagon>();
            int lengthOfTrain = RandomValues.ReturnRandomAmountOfVagons();
            for (int i = 0; i < lengthOfTrain; i++)
            {
                train.Add(new Wagon());
            }
            return train;
        }
        public static void ShowInfoAboutVagon (List<Wagon> train, int i)
        {
            Console.WriteLine("\t\t **Vagon**");           
            Console.WriteLine(train[i].ToString()); 
        }        
        public static int GetNextWagon(List<Wagon> train, int numberOfCurrentWagon)
        {
            if (numberOfCurrentWagon == train.Count - 1) return 0;
            else return numberOfCurrentWagon + 1;
        }
        public static int GetPreviousWagon(List<Wagon> train, int numberOfCurrentWagon)
        {
            if (numberOfCurrentWagon == 0) return train.Count - 1;
            else return numberOfCurrentWagon - 1;
        }
        public static int SkipWagonsFromFront(List<Wagon> train, int numberOfCurrentWagon, int amountSkipWagons)
        {
            while (numberOfCurrentWagon + amountSkipWagons > train.Count - 1)
            {
                amountSkipWagons = -(train.Count - amountSkipWagons);
            }
            return numberOfCurrentWagon += amountSkipWagons;
        }        
        public static int SkipWagonsFromBack(List<Wagon> train, int numberOfCurrentWagon, int amountSkipWagons)
        {
            if (numberOfCurrentWagon < amountSkipWagons)
            {
                while (numberOfCurrentWagon < amountSkipWagons)
                {
                    amountSkipWagons = Math.Abs(amountSkipWagons - numberOfCurrentWagon);
                }
                return train.Count - amountSkipWagons;
            }
            return numberOfCurrentWagon -= amountSkipWagons;
        }  
    }
}
