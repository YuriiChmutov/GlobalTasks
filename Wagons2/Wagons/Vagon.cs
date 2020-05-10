using System;
using System.Collections.Generic;
using System.Text;

namespace Wagons
{
    public class Vagon
    {
        public List<Light> lights = new List<Light>()
        {
            new Light(),
            new Light(),
            new Light(),
            new Light(),
            new Light(),
            new Light()
        };

        //public Light this[int index]
        //{
        //    get
        //    {
        //        return lights[index];
        //    }
        //    set
        //    {
        //        lights[index] = value;
        //    }
        //}

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            int i = 1;
            foreach (var item in lights)
            {
                if (item.isTurnedOn == true)
                {
                    builder.AppendLine($"Light {i}: On ");
                    i++;
                }
                else
                {
                    builder.AppendLine($"Light {i}: Off ");
                    i++;
                }
                    
            }
            return builder.ToString();
        }

    }
}
