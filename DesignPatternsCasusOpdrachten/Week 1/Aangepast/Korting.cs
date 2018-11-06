using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCasusOpdrachten.Week_1.Aangepast
{
    public interface Korting
    {
        double GetKorting(List<Pannenkoek> pannenkoeken);
    }
}
