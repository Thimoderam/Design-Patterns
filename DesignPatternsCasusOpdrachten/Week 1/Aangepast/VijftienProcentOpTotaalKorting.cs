using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCasusOpdrachten.Week_1.Aangepast
{
    class VijftienProcentOpTotaalKorting : Korting
    {
        public double GetKorting(List<Pannenkoek> pannenkoeken)
        {
            List<double> prijzen = new List<double>();
            foreach(Pannenkoek p in pannenkoeken)
            {
                prijzen.Add(p.Prijs());
            }
            double totaal = 0;
            foreach(double d in prijzen)
            {
                totaal += d;
            }
            return totaal * 0.15;
        }
    }
}
