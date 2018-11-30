using System;

namespace Bot_Farm {
    public class Animal {
        public string name;
        public AnimalRace race;

        public FacilityType housing;
        public Facility home;

        public double health;
        public double resistance;
        public Size size;


        public Animal(string name) {
            race = AnimalRace.Creature;
            this.name = name;
            home = null;
            resistance = (int)size;
        }

        public Animal() : this("Animal") { }

        public void GetInfo() {
            string homeInfo = home == null ? "none" : home.ToString();

            //TODO race.Lower()
            Console.WriteLine("" +
              "\nThis is a {0} named {1}" +
              "\nHealth: {2}" +
              "\nHome: {3}", 
              race.ToString().ToLower(), name, health, homeInfo);
        }
    }
}