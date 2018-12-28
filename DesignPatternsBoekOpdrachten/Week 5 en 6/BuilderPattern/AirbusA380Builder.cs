using System;

namespace DesignPatternsBoekOpdrachten.Week_5_en_6.BuilderPattern
{
    public class AirbusA380Builder : PlaneBuilder
    {
        public AirbusA380Builder(string callSign)
        {
            plane = new Plane(callSign);
        }
        public override void BuildAmountOfCrewNeeded()
        {
            plane.AmountOfCrewNeeded = 26;
        }

        public override void BuildAmountOfEngines()
        {
            plane.AmountOfEngines = 4;
        }

        public override void BuildAmountOfSeats()
        {
            plane.AmountOfSeats = 853;
        }

        public override void BuildIsCommercial()
        {
            plane.IsCommercial = true;
        }

        public override void BuildIsDirectFlight()
        {
            plane.IsDirectFlight = true;
        }

        public override void BuildIsPropAircraft()
        {
            plane.IsPropAircraft = false;
        }

        public override void BuildTopSpeed()
        {
            plane.Topspeed = 1020;
        }
    }
}
