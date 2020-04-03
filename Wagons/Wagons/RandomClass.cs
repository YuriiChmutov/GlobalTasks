using System;
using System.Collections.Generic;
using System.Text;

namespace Wagons
{
    
    static class RandomClass
    {
        static Random random = new Random();
        public static bool randomForLight() =>      
             random.Next(DateTime.Now.Millisecond) % 2 == 0 ? true : false;


        public static int randomAmountOfVagons() 
        {
            int randomValue = random.Next(DateTime.Now.Millisecond) % 10;
            if (randomValue == 0 || randomValue == 1)
            {               
                return randomValue + 5;
            }
            else {               
                return randomValue;
            }             
        }   
        
        public static int occurrenceVagon(int amountOfVagons) => random.Next(0, amountOfVagons - 1);

    }
}
