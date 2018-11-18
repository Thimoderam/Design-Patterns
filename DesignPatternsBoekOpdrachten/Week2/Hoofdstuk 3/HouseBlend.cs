namespace DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_3
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }
        override public double Cost()
        {
            return .89;
        }
    }
}
