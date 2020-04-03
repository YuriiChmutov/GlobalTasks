using System;
using System.Collections.Generic;
using System.Text;

namespace Wagons
{
    public class Light
    {
        public bool isTurnedOn;

        public Light()
        {
            isTurnedOn = RandomClass.randomForLight();
        }

    }
}
