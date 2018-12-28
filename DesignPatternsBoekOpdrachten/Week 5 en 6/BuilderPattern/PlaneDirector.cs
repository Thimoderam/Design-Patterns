using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBoekOpdrachten.Week_5_en_6.BuilderPattern
{
    public class PlaneDirector
    {
        public void Construct(PlaneBuilder planeBuilder)
        {
            planeBuilder.BuildAmountOfCrewNeeded();
            planeBuilder.BuildAmountOfEngines();
            planeBuilder.BuildAmountOfSeats();
            planeBuilder.BuildIsCommercial();
            planeBuilder.BuildIsDirectFlight();
            planeBuilder.BuildIsPropAircraft();
            planeBuilder.BuildTopSpeed();
        }
    }
}
