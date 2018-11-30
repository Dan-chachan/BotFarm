namespace Bot_Farm
{
    public class Facility
    {
        string name;
        Bot assignedBot;
        FacilityType type;
        object[] occupatedBy;
        Status status;

        public Facility(FacilityType t) { 
            type = t;
            name = t.ToString(); //TODO
            status = Status.Ok;
            assignedBot = null;
        }

        public void SetBot(Bot b) { assignedBot = b; }

        public void GetStatus() {
            string bot;
            if (assignedBot == null) {
                bot = "No";
            } else {
                bot = assignedBot.GetName();
            }
            System.Console.WriteLine("\n Type: {0}\n Status: {1}\n Bot: {2}", 
                                     type, status, bot);
        }
    }
}
