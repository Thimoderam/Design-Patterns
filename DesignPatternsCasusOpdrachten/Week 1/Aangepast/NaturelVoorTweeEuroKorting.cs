using System.Collections.Generic;

namespace DesignPatternsCasusOpdrachten.Week_1.Aangepast
{
    internal class NaturelVoorTweeEuroKorting : Korting
    {
        public double GetKorting(List<Pannenkoek> pannenkoeken)
        {
            var naturelTeller = 0;
            foreach (var p in pannenkoeken)
                if (p.Beschrijving().Equals("Naturelpannenkoek"))
                    naturelTeller++;
            return naturelTeller * 1.50;
        }
    }
}