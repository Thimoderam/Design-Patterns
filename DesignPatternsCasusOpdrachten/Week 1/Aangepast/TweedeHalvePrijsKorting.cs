﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCasusOpdrachten.Week_1.Aangepast
{
    class TweedeHalvePrijsKorting : Korting
    {
        public double GetKorting(List<Pannenkoek> pannenkoeken)
        {
            if (pannenkoeken.Count < 2)return 0;//als de lijst groter is dan 1 pannenkoek is er pas korting te krijgen.
            List<double> prijzen = new List<double>();
            foreach(Pannenkoek p in pannenkoeken)
            {
                prijzen.Add(p.Prijs());
            }
            prijzen.Sort(); //kleinste bedrag komt op index 0, dit zien we als de 2e pannenkoek.
            return prijzen[0] / 2;
        }
    }
}
