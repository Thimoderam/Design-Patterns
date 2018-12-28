namespace DesignPatternsBoekOpdrachten.Week_5_en_6
{
    public class Spitfire : FlyingObject
    {
        private int cargoSpace;
        private string description;
        private bool hasGuns;
        private bool hasMissiles;
        private bool isHostile;
        private bool isMachCapable;
        private string name;

        public Spitfire()
        {
            SetName();
            SetDescription();
        }

        public void SetName()
        {
            name = "Spitfire";
        }

        public void SetDescription()
        {
            description = "Mighty old single engine fighter";
        }

        public void SetCargoSpace(int cargoSpace)
        {
            this.cargoSpace = cargoSpace;
        }

        public void SetMachCapable()
        {
            isMachCapable = false;
        }

        public void SetHasGuns(bool hasGuns)
        {
            this.hasGuns = hasGuns;
        }

        public void SetHasMissiles(bool hasMissiles)
        {
            this.hasMissiles = hasMissiles;
        }

        public void SetIsHostile()
        {
            isHostile = false;
        }

        public override string ToString()
        {
            return
                $"{nameof(name)}: {name}, {nameof(description)}: {description}, {nameof(cargoSpace)}: {cargoSpace}, {nameof(isMachCapable)}: {isMachCapable}, {nameof(hasGuns)}: {hasGuns}, {nameof(hasMissiles)}: {hasMissiles}, {nameof(isHostile)}: {isHostile}";
        }
    }
}