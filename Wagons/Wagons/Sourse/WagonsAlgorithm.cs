using System.Collections.Generic;
using System.Diagnostics;
using Wagons.Model;

namespace Wagons.Sourse
{
    public static class WagonsAlgorithm
    {
        public static bool IsStartWagonTurnedOff(List<Wagon> train, int numberOfCurrentWagon, int amountSkipWagons)
        {
            numberOfCurrentWagon = TrainManagement.SkipWagonsFromFront(train, numberOfCurrentWagon, amountSkipWagons);
            if (train[numberOfCurrentWagon].light.IsTurnedOn == true) return true;
            else return false;
        }
        public static int CalculateAmountOfWagons(List<Wagon> train)
        {
            Debug.WriteLine(train.Count);
            int currentIndexOfWagon = RandomValues.ReturnNumberOfStartWagon(train.Count);
                       
            train[currentIndexOfWagon].light.IsTurnedOn = false;
            currentIndexOfWagon = TrainManagement.GetPreviousWagon(train, currentIndexOfWagon);
            train[currentIndexOfWagon].light.IsTurnedOn = true;
            currentIndexOfWagon = TrainManagement.GetPreviousWagon(train, currentIndexOfWagon);
            
            int counter = 2;         
            
            if (IsStartWagonTurnedOff(train, currentIndexOfWagon, counter)) return counter;

            else
            {                
                while (!IsStartWagonTurnedOff(train, currentIndexOfWagon, counter))
                {
                    counter++;
                    currentIndexOfWagon = TrainManagement.GetPreviousWagon(train, currentIndexOfWagon);

                    if (!train[currentIndexOfWagon].light.IsTurnedOn)
                    {
                        train[currentIndexOfWagon].light.IsTurnedOn = TrainManagement.SwapLightState(train[currentIndexOfWagon].light.IsTurnedOn);
                    }
                }
                return counter;
            }           
        }
    }
}
