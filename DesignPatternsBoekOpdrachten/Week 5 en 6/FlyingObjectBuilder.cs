namespace DesignPatternsBoekOpdrachten.Week_5_en_6
{
    public interface FlyingObjectBuilder
    {
        void BuildCargoSpace(int cargoSpace);
        void BuildHasGuns(bool hasGuns);
        void BuildHasMissiles(bool hasMissiles);
        FlyingObject GetFlyingObject();
    }
}