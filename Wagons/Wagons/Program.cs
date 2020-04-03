using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace Wagons
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();
            List<Vagon> train = new List<Vagon>();
            logic.createTrain(train);
            logic.trainFunction(train);
        }
    }
}
