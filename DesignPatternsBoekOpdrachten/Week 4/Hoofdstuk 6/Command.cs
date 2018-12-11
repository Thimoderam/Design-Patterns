using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_6
{
    public interface Command
    {
        void Execute();
        void Undo();
    }
}
