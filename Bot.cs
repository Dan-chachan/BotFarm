
using System.Collections.Generic;

namespace Bot_Farm
{
    public class Bot
    {
        Facility assignedFacility;

        List<Qualification> quals;
        string name;

        double battery;



        public Bot(Qualification q)
        {
            quals = new List<Qualification> { q };
            name = ((q == Qualification.No) ? "Slave" : q.ToString()) + " bot";
        }

        public Bot() : this(Qualification.No) { }


        void SetFacility(Facility f) { assignedFacility = f; }
        void SetQualification(Qualification q) { quals.Add(q); }

        public void SetName(string name) { this.name = name; }
        public string GetName() { return name; }

        public string GetQuals() {
            string strQuals = "";
            foreach (Qualification q in quals) {
                strQuals += q.ToString();
            }

            return strQuals;
        }


        public void ChargeSelf() {
            // ???
            while (battery < 1.0) {
                battery += 0.05;
            }

        }

        public void CheckStatus() {
            if (battery < 0.1) {
                ChargeSelf();
            }
        }
    }
}
