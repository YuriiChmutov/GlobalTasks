using Wagons.Sourse;

namespace Wagons.Model
{
    public class Light
    {
        public bool IsTurnedOn { get; set; }
        public Light()
        {
            IsTurnedOn = RandomValues.ReturnStanForLight();
        }

    }
}
