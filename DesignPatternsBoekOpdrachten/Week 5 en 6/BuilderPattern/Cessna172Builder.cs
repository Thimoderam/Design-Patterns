using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBoekOpdrachten.Week_5_en_6.BuilderPattern
{
    public class Cessna172Builder : PlaneBuilder
    {
        public Cessna172Builder(string callSign)
        {
            plane = new Plane(callSign);
        }
        public override void BuildAmountOfCrewNeeded()
        {
            plane.AmountOfCrewNeeded = 2;
        }

        public override void BuildAmountOfEngines()
        {
            plane.AmountOfEngines = 1;
        }

        public override void BuildAmountOfSeats()
        {
            plane.AmountOfSeats = 4;
        }

        public override void BuildIsCommercial()
        {
            plane.IsCommercial = false;
        }

        public override void BuildIsDirectFlight()
        {
            plane.IsDirectFlight = false;
        }

        public override void BuildIsPropAircraft()
        {
            plane.IsPropAircraft = true;
        }

        public override void BuildTopSpeed()
        {
            plane.Topspeed = 302;
        }
    }
}
