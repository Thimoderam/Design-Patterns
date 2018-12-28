using System;

namespace DesignPatternsBoekOpdrachten.Week_5_en_6.BuilderPattern
{
    public class Plane
    {
        private string callsign;
        private int topspeed;
        private int amountOfCrewNeeded;
        private int amountOfEngines;
        private int amountOfSeats;
        private bool isCommercial;
        private bool isDirectFlight;
        private bool isPropAircraft;
        public string Callsign { get => callsign; set => callsign = value; }
        public int Topspeed { get => topspeed; set => topspeed = value; }
        public int AmountOfCrewNeeded { get => amountOfCrewNeeded; set => amountOfCrewNeeded = value; }
        public int AmountOfEngines { get => amountOfEngines; set => amountOfEngines = value; }
        public int AmountOfSeats { get => amountOfSeats; set => amountOfSeats = value; }
        public bool IsCommercial { get => isCommercial; set => isCommercial = value; }
        public bool IsDirectFlight { get => isDirectFlight; set => isDirectFlight = value; }
        public bool IsPropAircraft { get => isPropAircraft; set => isPropAircraft = value; }
        public Plane(string callsign)
        {
            this.Callsign = callsign;
        }

        public void ShowInfo()
        {
            string printString = String.Format("Callsign : {0}\n" +
                "TopSpeed : {1}\n" +
                "Amount of crew needed : {2}\n" +
                "Amount of engines : {3}\n" +
                "Amount of seats : {4}\n" +
                "Is a commercial flight : {5}\n" +
                "Is a direct flight : {6}\n" +
                "Is a propellor driven aircraft : {7}\n",
                callsign, topspeed, amountOfCrewNeeded,
                amountOfEngines, amountOfSeats, isCommercial,
                isDirectFlight, isPropAircraft)
                .Replace("\n", Environment.NewLine);
            Console.WriteLine(printString);
        }
    }
}
