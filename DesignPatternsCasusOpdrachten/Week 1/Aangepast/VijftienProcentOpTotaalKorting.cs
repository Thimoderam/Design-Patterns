using System.Collections.Generic;

namespace DesignPatternsCasusOpdrachten.Week_1.Aangepast
{
    internal class VijftienProcentOpTotaalKorting : Korting
    {
        public double GetKorting(List<Pannenkoek> pannenkoeken)
        {
            var prijzen = new List<double>();
            foreach (var p in pannenkoeken) prijzen.Add(p.Prijs());
            double totaal = 0;
            foreach (var d in prijzen) totaal += d;
            return totaal * 0.15;
        }
    }
}