namespace DesignPatternsBoekOpdrachten.Week_5_en_6
{
    public interface FlyingObject
    {
        void SetName();
        void SetDescription();
        void SetCargoSpace(int cargoSpace);
        void SetMachCapable();
        void SetHasGuns(bool hasGuns);
        void SetHasMissiles(bool hasMissiles);
        void SetIsHostile();
    }
}