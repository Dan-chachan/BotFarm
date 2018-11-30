using System.Collections.Generic;

namespace Bot_Farm {
    class Farm {
        string name;
        int cash;

        public List<Facility> facilities;

        public List<Bot> bots;
        byte botCapacity;
        byte botAmount;

        public List<Animal> animals;
        byte animalCapacity;
        byte animalAmount;

        public Farm(string name, int startMoney, byte capacity) {
            this.name = name;
            cash = startMoney;

            // TODO separate capacities?
            facilities = new List<Facility>(capacity);

            botCapacity = capacity;
            bots = new List<Bot>(capacity);

            animalCapacity = capacity;
            animals = new List<Animal>(capacity);
        }

        public void BuyBot(Qualification desiredQual) {
            // search market, filter by prices etc.
            int cost = Prices.botPrices[desiredQual];

            bool success = SpendMoney(cost);
            if (success) {
                Bot newBot = new Bot(desiredQual);
                botAmount += 1;
                bots.Add(newBot);
            }
            System.Console.WriteLine(
                 PurchaseResult(("bot with " + desiredQual + " qualification").ToLower(), success, cost));
        }

        public void BuyAnimal(AnimalRace desiredRace) {
            if (!Prices.animalPrices.ContainsKey(desiredRace)) { 
                System.Console.WriteLine("\n No animals like that are currently being sold\n");
                return; 
            }

            int cost = Prices.animalPrices[desiredRace];

            Animal boi;
            bool success;
            // TODO

            if (SpendMoney(cost)) {
                switch (desiredRace) {
                    case AnimalRace.Chicken:
                        boi = new Chicken();
                        break;
                    case AnimalRace.Pig:
                        boi = new Pig();
                        break;
                    case AnimalRace.Cow:
                        boi = new Cow();
                        break;
                    default:
                        boi = new Animal();
                        break;
                }

                animals.Add(boi);
                animalAmount += 1;
                success = true;
            } else {
                success = false;
            }

            System.Console.WriteLine(PurchaseResult(("" + desiredRace).ToLower(), success, cost));
        }

        public void BuyFacility(FacilityType desiredType) {
            // TODO
            int cost = Prices.facilPrices[desiredType];

            bool success = SpendMoney(cost);

            if (success)
            {
                Facility newFac = new Facility(desiredType);
                facilities.Add(newFac);
            }
            System.Console.WriteLine(
                 PurchaseResult(desiredType.ToString().ToLower(), success, cost));

        }

        public static string PurchaseResult(string thingBought, bool success, int price) {
            if (success) {
                return "\nSucessfully bought a " + thingBought + " for " + price + "\n";
            }
            return "\nInsuficient funds for a " + thingBought + " at the price of " + price + "\n";
        }

        public bool SpendMoney(int amount) {
            if (amount > cash) { return false; }

            cash -= amount;
            return true;
        }

        public void GetBots() {
            string strBots = (botAmount == 1) ? "bot" : "bots";
            System.Console.WriteLine("This farm has {0} {1}\n", botAmount, strBots);
            foreach (Bot b in bots) {
                System.Console.WriteLine("~~{0}~~\nQualifications: {1}\n\n", 
                                         b.GetName(), b.GetQuals());
            }
        }

        public void GetAnimals() {
            string strAnim = (animalAmount == 1) ? "animal" : "animals";
            System.Console.WriteLine("This farm has {0} {1}\n", animalAmount, strAnim);
            foreach (Animal a in animals)
            {
                System.Console.WriteLine("\n" + a.race + "\n");
            }
        }
    }

}