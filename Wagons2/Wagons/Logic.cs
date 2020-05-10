using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Wagons
{
    public class Logic
    {
      
        public List<Vagon> createTrain (List<Vagon> train)
        {
            for (int i = 0; i < RandomClass.randomAmountOfVagons(); i++)
            {
                train.Add(new Vagon());
            }
            return train;
        }

        public void showInfoAboutVagon (List<Vagon> train, int i)
        {
            Console.WriteLine("\t\t **Vagon**");
            //int i = 1;
            //foreach (var item in lights)
            //{
            //    Console.WriteLine($"Light {i}: {item.isTurnedOn}");
            //    i++;
            //}
            Console.WriteLine(train[i].ToString()); 
        }

        public bool changeLight(bool stan) => stan == true ? false : true;
            
        public Vagon nextVagon(List<Vagon> train, int i)
        {
            if (i == train.Count - 1) return train[0];
            else return train[i + 1];
        }

        public int next(List<Vagon> train, int i)
        {
            if (i == train.Count - 1) return 0;
            else return i+1;
        }

        public int previous(List<Vagon> train, int i)
        {
            if (i == 0) return train.Count - 1;
            else return i-1;
        }

        public void trainFunction(List<Vagon> train)
        {
            Console.WriteLine(train.Count);
            int i = RandomClass.occurrenceVagon(train.Count);
   label:   showInfoAboutVagon(train, i);
            askAmount(train.Count);

            Console.Write($"Do you want to change light?(y) ");
            char change = Console.ReadLine().ToCharArray().First();
            if (change == 'y')
            {
                Console.Write($"Which one do you want to change?");
                char numberOfLight = Console.ReadLine().ToCharArray().First();
                int num = Convert.ToInt32(numberOfLight.ToString());

                train[i].lights[num - 1].isTurnedOn = changeLight(train[i].lights[num - 1].isTurnedOn);                
                goto label;
            }
            else
            {
                Console.Write($"Go to the next(n) or previous(p) vagon? ");
                char nextChar = Console.ReadLine().ToCharArray().First();

                if (nextChar == 'n')
                {
                    i = next(train, i);
                    goto label;
                }
                else if (nextChar == 'p')
                {
                    i = previous(train, i);
                    goto label;
                }
            }
        }

        public void askAmount (int amountOfVagons)
        {
            Console.Write($"Are you ready to say amount? (y)");
            char answer = Console.ReadLine().ToCharArray().First();
            if (answer == 'y')
            {
                Console.Write($"Input -> ");
                char amount = Console.ReadLine().ToCharArray().First();
                int Amount = Convert.ToInt32(amount.ToString());

                if(amountOfVagons == Amount)
                {
                    Console.WriteLine($"Your answer is right!");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine($"It`s wrong");
                    Console.ReadLine();
                }
            }
            else Console.ReadLine();
        } 

    }
}
