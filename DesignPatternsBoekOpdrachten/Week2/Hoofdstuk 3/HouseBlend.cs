namespace DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_3
{
    internal class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}