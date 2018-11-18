namespace DesignPatternsBoekOpdrachten.Week2.Hoofdstuk_3
{
    class Espresso : Beverage
    {
        public Espresso(){
            description = "Espresso";
        }

        override public double Cost()
        {
            return 1.99;
        }
    }
}
