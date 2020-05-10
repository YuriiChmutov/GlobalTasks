using System.Text;

namespace Wagons.Model
{
    public class Wagon
    {
        public Light light = null;
        public Wagon()
        {
            light = new Light();
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            if(light.IsTurnedOn == true) builder.AppendLine($"Light: On ");
            else builder.AppendLine($"Light: Off ");
            return builder.ToString();
        }
    }
}
