using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_10
{
    public interface State
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}
