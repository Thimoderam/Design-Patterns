namespace DesignPatternsBoekOpdrachten.Week_5_en_6
{
    public class FlyingObjectDirector
    {
        private readonly FlyingObjectBuilder flyingObjectBuilder;

        public FlyingObjectDirector(FlyingObjectBuilder builder)
        {
            flyingObjectBuilder = builder;
        }

        private FlyingObject GetFlyingObject()
        {
            return flyingObjectBuilder.GetFlyingObject();
        }

        public void CreateSpitFire()
        {
            flyingObjectBuilder.BuildCargoSpace(1);
            flyingObjectBuilder.BuildHasGuns(true);
        }
    }
}