using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_10
{
    public class GumballMachineTest
    {
        public GumballMachineTest()
        {
            GumballMachine gumballMachine = new GumballMachine(5);
            Console.WriteLine(gumballMachine);
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine);
        }
    }
}
