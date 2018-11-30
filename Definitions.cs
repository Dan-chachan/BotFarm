using System;
using System.Collections.Generic;

namespace Bot_Farm
{
    public enum Qualification { Commanding, Farming, Caretaking, Business, No };
    public enum FacilityType { Field, Stable, Coop, House, Shed, Pigsty };
    public enum Size { Small, Medium, Large };
    public enum Status { Ok, Help, Warning, Urgent }; // Error?
    public enum AnimalRace { Chicken, Pig, Cow, Creature };

    public abstract class Prices
    {
        // TODO refactor
        public static Dictionary<AnimalRace, int> animalPrices = new Dictionary<AnimalRace, int>();
        public static Dictionary<Qualification, int> botPrices = new Dictionary<Qualification, int>();
        public static Dictionary<FacilityType, int> facilPrices = new Dictionary<FacilityType, int>();


        static Prices() {
            animalPrices.Add(AnimalRace.Chicken, 10);
            animalPrices.Add(AnimalRace.Pig, 30);
            animalPrices.Add(AnimalRace.Cow, 50);

            botPrices.Add(Qualification.Commanding, 350);
            botPrices.Add(Qualification.Business, 300);
            botPrices.Add(Qualification.Caretaking, 250);
            botPrices.Add(Qualification.Farming, 200);
            botPrices.Add(Qualification.No, 100);

            facilPrices.Add(FacilityType.House, 1000);
            facilPrices.Add(FacilityType.Stable, 800);
            facilPrices.Add(FacilityType.Coop, 600);
            facilPrices.Add(FacilityType.Shed, 550);
            facilPrices.Add(FacilityType.Pigsty, 500);
            facilPrices.Add(FacilityType.Field, 200);
        }
    } 


}
