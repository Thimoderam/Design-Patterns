using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBoekOpdrachten.Week_1
{
    class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}
