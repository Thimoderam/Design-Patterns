using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCasusOpdrachten.Week_1.Aangepast
{
    class NaturelVoorTweeEuroKorting : Korting
    {
        public double GetKorting(List<Pannenkoek> pannenkoeken)
        {
            int naturelTeller = 0;
            foreach(Pannenkoek p in pannenkoeken)
            {
                if (p.Beschrijving().Equals("Naturelpannenkoek"))
                {
                    naturelTeller++;
                }
            }
            return naturelTeller * 1.50;
        }
    }
}
