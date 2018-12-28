using System.Collections.Generic;

namespace DesignPatternsCasusOpdrachten.Week_1.Aangepast
{
    public interface Korting
    {
        double GetKorting(List<Pannenkoek> pannenkoeken);
    }
}