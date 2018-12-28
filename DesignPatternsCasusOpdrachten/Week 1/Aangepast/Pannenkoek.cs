namespace DesignPatternsCasusOpdrachten.Week_1.Aangepast
{
    public class Pannenkoek
    {
        private readonly string beschrijving;
        private readonly double prijs;

        public Pannenkoek(string beschr, double pr)
        {
            beschrijving = beschr;
            prijs = pr;
        }

        /// <summary>
        ///     Geeft de beschrijving van de pannenkoek
        /// </summary>
        /// <returns></returns>
        public string Beschrijving()
        {
            return beschrijving;
        }

        /// <summary>
        ///     Geeft de prijs van de pannenkoek (bijvoorbeeld in Euro)
        /// </summary>
        /// <returns></returns>
        public double Prijs()
        {
            return prijs;
        }
    }
}