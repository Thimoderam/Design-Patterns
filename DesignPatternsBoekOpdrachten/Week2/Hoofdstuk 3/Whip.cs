namespace DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_3
{
    class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        override public string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        override public double Cost()
        {
            return beverage.Cost() + .10;
        }
    }
}
