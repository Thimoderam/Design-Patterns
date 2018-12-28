namespace DesignPatternsBoekOpdrachten.Week_5_en_6.BuilderPattern
{
    public abstract class PlaneBuilder
    {
        protected Plane plane;

        public Plane Plane { get => plane; }
        public abstract void BuildTopSpeed();
        public abstract void BuildAmountOfCrewNeeded();
        public abstract void BuildAmountOfEngines();
        public abstract void BuildAmountOfSeats();
        public abstract void BuildIsCommercial();
        public abstract void BuildIsDirectFlight();
        public abstract void BuildIsPropAircraft();
    }
}
