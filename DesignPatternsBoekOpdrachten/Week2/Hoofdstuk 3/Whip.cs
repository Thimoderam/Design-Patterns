namespace DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_3
{
    internal class Whip : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return beverage.Cost() + .10;
        }
    }
}