namespace DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_3
{
    internal class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}