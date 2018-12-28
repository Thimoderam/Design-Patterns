namespace DesignPatternsBoekOpdrachten.Week_5_en_6
{
    public class SpitfireBuilder : FlyingObjectBuilder
    {
        private readonly FlyingObject flyingObject;

        public SpitfireBuilder()
        {
            flyingObject = new Spitfire();
        }

        public void BuildCargoSpace(int cargoSpace)
        {
            flyingObject.SetCargoSpace(cargoSpace);
        }

        public void BuildHasGuns(bool hasGuns)
        {
            flyingObject.SetHasGuns(hasGuns);
        }

        public void BuildHasMissiles(bool hasMissiles)
        {
            flyingObject.SetHasMissiles(hasMissiles);
        }

        public FlyingObject GetFlyingObject()
        {
            return flyingObject;
        }
    }
}