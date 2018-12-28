namespace DesignPatternsCasusOpdrachten.Week_1.Origineel
{
    /// <summary>
    ///     Een simpele pannenkoek klasse.
    ///     Een pannenkoek heeft een beschrijving en een prijs, die
    ///     beide read-only zijn en tijdens constructie worden vastgelegd.
    ///     In deze eerste versie zijn alle pannenkoeken nog van
    ///     hetzelfde type, en kunnen er nog geen ingredienten
    ///     worden toegevoegd.
    ///     In een volgende versie worden met het Decorator design pattern
    ///     wrappers voor deze basisklasse gemaakt om ingredienten toe
    ///     te kunnen voegen.
    /// </summary>
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