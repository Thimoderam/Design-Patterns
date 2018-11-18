namespace DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_3
{
    class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        override public string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        override public double Cost()
        {
            return beverage.Cost() + .20;
        }
    }
}
