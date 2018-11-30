using System;
namespace Bot_Farm
{
    public class Chicken : Animal
    {
        public Chicken(string name) : base(name)
        {
            race = AnimalRace.Chicken;

            health = 1.0;
            size = Size.Small;

            housing = FacilityType.Coop;
        }

        public Chicken() : this("Chicken") { }


    }
}
