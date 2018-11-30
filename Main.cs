using System;

namespace Bot_Farm
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Facility house = new Facility(FacilityType.House);

            Farm botenFarm = new Farm("Böten Farm", 1000, 10);

            //botenFarm.BuyBot(Qualification.Caretaking);
            //botenFarm.BuyBot(Qualification.Commanding);

            //botenFarm.GetBots();

            botenFarm.BuyAnimal(AnimalRace.Chicken);
            botenFarm.BuyAnimal(AnimalRace.Pig);
            botenFarm.BuyAnimal(AnimalRace.Cow);

            botenFarm.GetAnimals();
            botenFarm.animals[0].GetInfo();

            botenFarm.BuyFacility(FacilityType.Coop);


        }
    }
}
